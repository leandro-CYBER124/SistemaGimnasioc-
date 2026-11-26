USE bd_gimnasio;
GO

-- ===================================================================== USUARIOS
CREATE OR ALTER PROCEDURE dbo.SP_ObtenerUsuario
    @Documento NVARCHAR(15)
AS
BEGIN
    SELECT TOP 1 u.id_usuario, u.documento, u.nombre_completo, u.clave_hash, r.nombre AS rol, u.estado
    FROM dbo.usuario u
    INNER JOIN dbo.rol r ON r.id_rol = u.id_rol
    WHERE u.documento = @Documento
END
GO

-- ===================================================================== PLANES
CREATE OR ALTER PROCEDURE dbo.SP_ListarPlanes
AS
BEGIN
    SELECT id_plan, nombre, precio, duracion_dias, estado
    FROM dbo.plan_membresia
    ORDER BY duracion_dias, precio
END
GO

CREATE OR ALTER PROCEDURE dbo.SP_ObtenerPlan
    @IdPlan INT
AS
BEGIN
    SELECT id_plan, nombre, precio, duracion_dias, estado
    FROM dbo.plan_membresia
    WHERE id_plan = @IdPlan
END
GO

CREATE OR ALTER PROCEDURE dbo.SP_RegistrarPlan
    @Nombre        NVARCHAR(60),
    @Precio        DECIMAL(10,2),
    @DuracionDias  INT,
    @Estado        BIT,
    @Mensaje       NVARCHAR(500) OUTPUT
AS
BEGIN
    SET @Mensaje = ''

    IF EXISTS (SELECT 1 FROM dbo.plan_membresia WHERE nombre = @Nombre)
    BEGIN
        SET @Mensaje = N'Ya existe un plan con ese nombre.'
        RETURN
    END

    INSERT INTO dbo.plan_membresia (nombre, precio, duracion_dias, estado)
    VALUES (@Nombre, @Precio, @DuracionDias, @Estado)
END
GO

CREATE OR ALTER PROCEDURE dbo.SP_EditarPlan
    @IdPlan        INT,
    @Nombre        NVARCHAR(60),
    @Precio        DECIMAL(10,2),
    @DuracionDias  INT,
    @Estado        BIT,
    @Mensaje       NVARCHAR(500) OUTPUT
AS
BEGIN
    SET @Mensaje = ''

    -- El nombre no puede repetirse en OTRO plan (el propio plan se excluye con id_plan <> @IdPlan).
    IF EXISTS (SELECT 1 FROM dbo.plan_membresia WHERE nombre = @Nombre AND id_plan <> @IdPlan)
    BEGIN
        SET @Mensaje = N'Ya existe un plan con ese nombre.'
        RETURN
    END

    UPDATE dbo.plan_membresia
    SET nombre = @Nombre, precio = @Precio, duracion_dias = @DuracionDias, estado = @Estado
    WHERE id_plan = @IdPlan
END
GO

-- ===================================================================== SOCIOS
CREATE OR ALTER PROCEDURE dbo.SP_ListarSocios
    @Texto NVARCHAR(100)
AS
BEGIN
    SELECT *
    FROM dbo.vw_socio_estado
    WHERE dni LIKE '%' + @Texto + '%' OR nombre LIKE '%' + @Texto + '%' OR apellido LIKE '%' + @Texto + '%'
    ORDER BY apellido, nombre
END
GO

CREATE OR ALTER PROCEDURE dbo.SP_ObtenerSocioPorId
    @IdSocio INT
AS
BEGIN
    SELECT * FROM dbo.vw_socio_estado WHERE id_socio = @IdSocio
END
GO

CREATE OR ALTER PROCEDURE dbo.SP_ObtenerSocioPorDni
    @Dni NVARCHAR(8)
AS
BEGIN
    SELECT * FROM dbo.vw_socio_estado WHERE dni = @Dni
END
GO

CREATE OR ALTER PROCEDURE dbo.SP_RegistrarSocio
    @Dni       NVARCHAR(8),
    @Nombre    NVARCHAR(60),
    @Apellido  NVARCHAR(60),
    @Telefono  NVARCHAR(20),
    @Email     NVARCHAR(100),
    @IdPlan    INT,
    @Estado    BIT,
    @IdUsuario INT,
    @Mensaje   NVARCHAR(500) OUTPUT
AS
BEGIN
    SET @Mensaje = ''

    IF EXISTS (SELECT 1 FROM dbo.socio WHERE dni = @Dni)
    BEGIN
        SET @Mensaje = N'Ya existe un socio con ese DNI.'
        RETURN
    END

    DECLARE @IdSocio INT
    DECLARE @FechaAlta DATE = CAST(GETDATE() AS DATE)
    DECLARE @FechaVencimiento DATE
    DECLARE @DuracionDias INT

    -- Obtener duración del plan
    SELECT @DuracionDias = duracion_dias FROM dbo.plan_membresia WHERE id_plan = @IdPlan

    IF @DuracionDias IS NULL
    BEGIN
        SET @Mensaje = N'El plan no existe.'
        RETURN
    END

    -- Crear el socio
    INSERT INTO dbo.socio (dni, nombre, apellido, telefono, email, fecha_alta, id_plan, estado)
    VALUES (@Dni, @Nombre, @Apellido, @Telefono, @Email, @FechaAlta, @IdPlan, @Estado)

    -- Obtener el ID del socio recién creado
    SET @IdSocio = SCOPE_IDENTITY()

    -- Calcular fecha de vencimiento: hoy + duración del plan
    SET @FechaVencimiento = DATEADD(DAY, @DuracionDias, @FechaAlta)

    -- Crear la primera cuota (pago inicial)
    INSERT INTO dbo.cuota (id_socio, id_plan, fecha_pago, fecha_desde, fecha_vencimiento, monto, medio_pago, id_usuario)
    SELECT @IdSocio, @IdPlan, GETDATE(), @FechaAlta, @FechaVencimiento, precio, N'Inicial', @IdUsuario
    FROM dbo.plan_membresia
    WHERE id_plan = @IdPlan
END
GO

CREATE OR ALTER PROCEDURE dbo.SP_EditarSocio
    @IdSocio   INT,
    @Dni       NVARCHAR(8),
    @Nombre    NVARCHAR(60),
    @Apellido  NVARCHAR(60),
    @Telefono  NVARCHAR(20),
    @Email     NVARCHAR(100),
    @IdPlan    INT,
    @Estado    BIT,
    @Mensaje   NVARCHAR(500) OUTPUT
AS
BEGIN
    SET @Mensaje = ''

    IF EXISTS (SELECT 1 FROM dbo.socio WHERE dni = @Dni AND id_socio <> @IdSocio)
    BEGIN
        SET @Mensaje = N'Ya existe un socio con ese DNI.'
        RETURN
    END

    UPDATE dbo.socio
    SET dni = @Dni, nombre = @Nombre, apellido = @Apellido, telefono = @Telefono,
        email = @Email, id_plan = @IdPlan, estado = @Estado
    WHERE id_socio = @IdSocio
END
GO

-- Baja o reactivación: solo cambia el campo estado, el socio no se borra.
CREATE OR ALTER PROCEDURE dbo.SP_CambiarEstadoSocio
    @IdSocio INT,
    @Estado  BIT
AS
BEGIN
    UPDATE dbo.socio SET estado = @Estado WHERE id_socio = @IdSocio
END
GO

-- ===================================================================== CUOTAS
CREATE OR ALTER PROCEDURE dbo.SP_RegistrarCuota
    @IdSocio           INT,
    @IdPlan            INT,
    @FechaPago         DATETIME,
    @FechaDesde        DATE,
    @FechaVencimiento  DATE,
    @Monto             DECIMAL(10,2),
    @MedioPago         NVARCHAR(20),
    @IdUsuario         INT,
    @Mensaje           NVARCHAR(500) OUTPUT
AS
BEGIN
    SET @Mensaje = ''

    IF NOT EXISTS (SELECT 1 FROM dbo.socio WHERE id_socio = @IdSocio AND estado = 1)
    BEGIN
        SET @Mensaje = N'El socio no existe o está dado de baja.'
        RETURN
    END

    INSERT INTO dbo.cuota (id_socio, id_plan, fecha_pago, fecha_desde, fecha_vencimiento, monto, medio_pago, id_usuario)
    VALUES (@IdSocio, @IdPlan, @FechaPago, @FechaDesde, @FechaVencimiento, @Monto, @MedioPago, @IdUsuario)
END
GO

CREATE OR ALTER PROCEDURE dbo.SP_ListarCuotasSocio
    @IdSocio INT
AS
BEGIN
    SELECT c.fecha_pago, c.fecha_desde, c.fecha_vencimiento, c.monto, c.medio_pago,
           u.nombre_completo AS cobrado_por
    FROM dbo.cuota c
    INNER JOIN dbo.usuario u ON u.id_usuario = c.id_usuario
    WHERE c.id_socio = @IdSocio
    ORDER BY c.fecha_pago DESC
END
GO

-- ===================================================================== ASISTENCIAS
CREATE OR ALTER PROCEDURE dbo.SP_RegistrarAsistencia
    @IdSocio    INT,
    @Permitido  BIT,
    @Motivo     NVARCHAR(150),
    @IdUsuario  INT
AS
BEGIN
    INSERT INTO dbo.asistencia (id_socio, fecha_hora, permitido, motivo, id_usuario)
    VALUES (@IdSocio, GETDATE(), @Permitido, @Motivo, @IdUsuario)
END
GO

CREATE OR ALTER PROCEDURE dbo.SP_ListarAsistenciasHoy
AS
BEGIN
    SELECT CONVERT(VARCHAR(5), a.fecha_hora, 108) AS hora,
           s.dni,
           s.apellido + ', ' + s.nombre AS socio,
           CASE WHEN a.permitido = 1 THEN 'Permitido' ELSE 'Denegado' END AS resultado,
           a.motivo
    FROM dbo.asistencia a
    INNER JOIN dbo.socio s ON s.id_socio = a.id_socio
    WHERE CAST(a.fecha_hora AS DATE) = CAST(GETDATE() AS DATE)
    ORDER BY a.fecha_hora DESC
END
GO

-- ===================================================================== DASHBOARD
-- Devuelve UNA fila con los cinco números de las tarjetas.
CREATE OR ALTER PROCEDURE dbo.SP_ResumenDashboard
AS
BEGIN
    SELECT
        (SELECT COUNT(*) FROM dbo.socio WHERE estado = 1) AS socios_activos,
        (SELECT COUNT(*) FROM dbo.vw_socio_estado WHERE estado = 1 AND estado_cuota = N'Al día') AS socios_al_dia,
        (SELECT COUNT(*) FROM dbo.vw_socio_estado WHERE estado = 1 AND estado_cuota <> N'Al día') AS morosos,
        (SELECT COALESCE(SUM(monto), 0) FROM dbo.cuota
          WHERE MONTH(fecha_pago) = MONTH(GETDATE()) AND YEAR(fecha_pago) = YEAR(GETDATE())) AS ingresos_mes,
        (SELECT COUNT(*) FROM dbo.asistencia
          WHERE permitido = 1 AND CAST(fecha_hora AS DATE) = CAST(GETDATE() AS DATE)) AS asistencias_hoy
END
GO

CREATE OR ALTER PROCEDURE dbo.SP_ListarMorosos
AS
BEGIN
    SELECT dni, apellido, nombre, telefono, nombre_plan, ultimo_vencimiento,
           DATEDIFF(DAY, ultimo_vencimiento, GETDATE()) AS dias_atraso
    FROM dbo.vw_socio_estado
    WHERE estado = 1 AND estado_cuota <> N'Al día'
    ORDER BY ultimo_vencimiento, apellido
END
GO

CREATE OR ALTER PROCEDURE dbo.SP_ListarPorVencer
AS
BEGIN
    SELECT dni, apellido, nombre, telefono, nombre_plan, ultimo_vencimiento,
           DATEDIFF(DAY, GETDATE(), ultimo_vencimiento) AS dias_restantes
    FROM dbo.vw_socio_estado
    WHERE estado = 1
      AND ultimo_vencimiento >= CAST(GETDATE() AS DATE)
      AND ultimo_vencimiento <= DATEADD(DAY, 7, CAST(GETDATE() AS DATE))
    ORDER BY ultimo_vencimiento, apellido
END
GO

-- Ingresos permitidos por día de los últimos 7 días (para el gráfico).
CREATE OR ALTER PROCEDURE dbo.SP_IngresosPorDia
AS
BEGIN
    SELECT CAST(fecha_hora AS DATE) AS dia, COUNT(*) AS cantidad
    FROM dbo.asistencia
    WHERE permitido = 1 AND fecha_hora >= DATEADD(DAY, -6, CAST(GETDATE() AS DATE))
    GROUP BY CAST(fecha_hora AS DATE)
    ORDER BY dia
END
GO
