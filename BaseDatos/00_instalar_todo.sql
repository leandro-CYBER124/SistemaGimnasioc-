-- =====================================================================
-- Gym Control (SQL Server) - 01: crear la base de datos
-- Ejecutar en SQL Server Management Studio (SSMS) con F5.
-- =====================================================================
USE master;
GO

IF DB_ID(N'bd_gimnasio') IS NULL
    CREATE DATABASE bd_gimnasio;
GO

-- =====================================================================
-- Gym Control (SQL Server) - 02: tablas
-- Si se vuelve a ejecutar, BORRA las tablas y las recrea vacías.
-- Después hay que volver a correr 03 y 04.
-- =====================================================================
USE bd_gimnasio;
GO

IF OBJECT_ID(N'dbo.vw_socio_estado', N'V') IS NOT NULL DROP VIEW dbo.vw_socio_estado;
IF OBJECT_ID(N'dbo.asistencia',      N'U') IS NOT NULL DROP TABLE dbo.asistencia;
IF OBJECT_ID(N'dbo.cuota',           N'U') IS NOT NULL DROP TABLE dbo.cuota;
IF OBJECT_ID(N'dbo.socio',           N'U') IS NOT NULL DROP TABLE dbo.socio;
IF OBJECT_ID(N'dbo.plan_membresia',  N'U') IS NOT NULL DROP TABLE dbo.plan_membresia;
IF OBJECT_ID(N'dbo.usuario',         N'U') IS NOT NULL DROP TABLE dbo.usuario;
IF OBJECT_ID(N'dbo.rol',             N'U') IS NOT NULL DROP TABLE dbo.rol;
GO

-- ROL: los tipos de usuario del sistema (Administrador, Recepcionista). Define los permisos.
CREATE TABLE dbo.rol (
    id_rol  INT IDENTITY(1,1) NOT NULL CONSTRAINT pk_rol PRIMARY KEY,
    nombre  NVARCHAR(30)      NOT NULL CONSTRAINT uq_rol_nombre UNIQUE
);
GO

-- USUARIO: las personas que inician sesión. La clave se guarda como hash SHA-256, nunca en texto plano.
-- id_rol es clave foránea (FK): cada usuario tiene que tener un rol que exista en la tabla rol.
CREATE TABLE dbo.usuario (
    id_usuario      INT IDENTITY(1,1) NOT NULL CONSTRAINT pk_usuario PRIMARY KEY,
    documento       NVARCHAR(15)      NOT NULL CONSTRAINT uq_usuario_documento UNIQUE,
    nombre_completo NVARCHAR(100)     NOT NULL,
    clave_hash      CHAR(64)          NOT NULL,          -- SHA-256 en hexadecimal
    id_rol          INT               NOT NULL,
    estado          BIT               NOT NULL CONSTRAINT df_usuario_estado DEFAULT 1,
    fecha_creacion  DATETIME          NOT NULL CONSTRAINT df_usuario_fecha DEFAULT GETDATE(),
    CONSTRAINT fk_usuario_rol FOREIGN KEY (id_rol) REFERENCES dbo.rol (id_rol)
);
GO

-- PLAN_MEMBRESIA: los planes que se venden. duracion_dias dice cuánto dura cada cuota.
-- Los CHECK impiden guardar precios <= 0 o duraciones fuera de rango, aunque falle la validación del programa.
CREATE TABLE dbo.plan_membresia (
    id_plan        INT IDENTITY(1,1) NOT NULL CONSTRAINT pk_plan PRIMARY KEY,
    nombre         NVARCHAR(60)      NOT NULL CONSTRAINT uq_plan_nombre UNIQUE,
    precio         DECIMAL(10,2)     NOT NULL,
    duracion_dias  INT               NOT NULL,
    estado         BIT               NOT NULL CONSTRAINT df_plan_estado DEFAULT 1,
    CONSTRAINT ck_plan_precio   CHECK (precio > 0),
    CONSTRAINT ck_plan_duracion CHECK (duracion_dias BETWEEN 1 AND 730)
);
GO

-- SOCIO: los clientes del gimnasio. El dni es UNIQUE (no puede repetirse).
-- estado = 0 es una baja LÓGICA: el socio sigue en la tabla para no perder su historial.
CREATE TABLE dbo.socio (
    id_socio   INT IDENTITY(1,1) NOT NULL CONSTRAINT pk_socio PRIMARY KEY,
    dni        NVARCHAR(8)       NOT NULL CONSTRAINT uq_socio_dni UNIQUE,
    nombre     NVARCHAR(60)      NOT NULL,
    apellido   NVARCHAR(60)      NOT NULL,
    telefono   NVARCHAR(20)      NULL,
    email      NVARCHAR(100)     NULL,
    fecha_alta DATE              NOT NULL,
    id_plan    INT               NOT NULL,
    estado     BIT               NOT NULL CONSTRAINT df_socio_estado DEFAULT 1,
    CONSTRAINT fk_socio_plan FOREIGN KEY (id_plan) REFERENCES dbo.plan_membresia (id_plan)
);
GO

-- CUOTA: historial de pagos. NO se guarda 'si el socio está al día': se calcula con el mayor
-- fecha_vencimiento de sus cuotas (ver la vista vw_socio_estado en el script 04).
CREATE TABLE dbo.cuota (
    id_cuota          INT IDENTITY(1,1) NOT NULL CONSTRAINT pk_cuota PRIMARY KEY,
    id_socio          INT               NOT NULL,
    id_plan           INT               NOT NULL,
    fecha_pago        DATETIME          NOT NULL,
    fecha_desde       DATE              NOT NULL,
    fecha_vencimiento DATE              NOT NULL,        -- último día válido (inclusive)
    monto             DECIMAL(10,2)     NOT NULL,
    medio_pago        NVARCHAR(20)      NOT NULL,
    id_usuario        INT               NOT NULL,
    CONSTRAINT fk_cuota_socio   FOREIGN KEY (id_socio)   REFERENCES dbo.socio (id_socio),
    CONSTRAINT fk_cuota_plan    FOREIGN KEY (id_plan)    REFERENCES dbo.plan_membresia (id_plan),
    CONSTRAINT fk_cuota_usuario FOREIGN KEY (id_usuario) REFERENCES dbo.usuario (id_usuario)
);
GO
-- Los índices aceleran las búsquedas más frecuentes (cuota vigente de un socio, pagos por fecha).
CREATE INDEX ix_cuota_socio_venc ON dbo.cuota (id_socio, fecha_vencimiento);
CREATE INDEX ix_cuota_fecha_pago ON dbo.cuota (fecha_pago);
GO

-- ASISTENCIA: cada intento de ingreso, permitido (1) o denegado (0) con su motivo.
CREATE TABLE dbo.asistencia (
    id_asistencia INT IDENTITY(1,1) NOT NULL CONSTRAINT pk_asistencia PRIMARY KEY,
    id_socio      INT               NOT NULL,
    fecha_hora    DATETIME          NOT NULL,
    permitido     BIT               NOT NULL,
    motivo        NVARCHAR(150)     NULL,
    id_usuario    INT               NOT NULL,
    CONSTRAINT fk_asistencia_socio   FOREIGN KEY (id_socio)   REFERENCES dbo.socio (id_socio),
    CONSTRAINT fk_asistencia_usuario FOREIGN KEY (id_usuario) REFERENCES dbo.usuario (id_usuario)
);
GO
CREATE INDEX ix_asistencia_fecha ON dbo.asistencia (fecha_hora);
GO

-- =====================================================================
-- Gym Control (SQL Server) - 03: datos de prueba
-- Las fechas son relativas a hoy (GETDATE()), así el dashboard siempre
-- muestra socios al día, por vencer y morosos sin importar cuándo se ejecute.
--
-- Usuarios de prueba:
--   Administrador  documento 10000001   clave admin123
--   Recepcionista  documento 10000002   clave recep123
-- =====================================================================
USE bd_gimnasio;
GO
SET NOCOUNT ON;

DECLARE @hoy DATE = CAST(GETDATE() AS DATE);

SET IDENTITY_INSERT dbo.rol ON;
INSERT INTO dbo.rol (id_rol, nombre) VALUES
(1, N'Administrador'),
(2, N'Recepcionista');
SET IDENTITY_INSERT dbo.rol OFF;

SET IDENTITY_INSERT dbo.usuario ON;
INSERT INTO dbo.usuario (id_usuario, documento, nombre_completo, clave_hash, id_rol, estado) VALUES
(1, N'10000001', N'Carolina Benítez', '240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9', 1, 1),
(2, N'10000002', N'Diego Romero',     '5d37ed314cf2b5c8462b52b12cd512e2ac4a180e75598da4f12bfb0dea6d0a67', 2, 1);
SET IDENTITY_INSERT dbo.usuario OFF;

SET IDENTITY_INSERT dbo.plan_membresia ON;
INSERT INTO dbo.plan_membresia (id_plan, nombre, precio, duracion_dias, estado) VALUES
(1, N'Mensual 3 veces por semana', 18000.00,  30, 1),
(2, N'Mensual libre',              25000.00,  30, 1),
(3, N'Trimestral libre',           65000.00,  90, 1),
(4, N'Anual libre',               220000.00, 365, 1);
SET IDENTITY_INSERT dbo.plan_membresia OFF;

SET IDENTITY_INSERT dbo.socio ON;
INSERT INTO dbo.socio (id_socio, dni, nombre, apellido, telefono, email, fecha_alta, id_plan, estado) VALUES
(1, N'40123456', N'Lucas', N'Fernández', N'3815550101', N'lucas.fernandez@mail.com', DATEADD(DAY, -200, @hoy), 2, 1),
(2, N'38234567', N'Camila', N'Rojas', N'3815550102', N'camila.rojas@mail.com', DATEADD(DAY, -150, @hoy), 2, 1),
(3, N'41345678', N'Mateo', N'Gómez', N'3815550103', NULL, DATEADD(DAY, -90, @hoy), 1, 1),
(4, N'36456789', N'Sofía', N'Herrera', N'3815550104', N'sofia.herrera@mail.com', DATEADD(DAY, -120, @hoy), 3, 1),
(5, N'42567890', N'Tomás', N'Aguirre', N'3815550105', NULL, DATEADD(DAY, -100, @hoy), 2, 1),
(6, N'39678901', N'Valentina', N'Díaz', N'3815550106', N'vale.diaz@mail.com', DATEADD(DAY, -80, @hoy), 1, 1),
(7, N'37789012', N'Joaquín', N'Paz', N'3815550107', NULL, DATEADD(DAY, -140, @hoy), 2, 1),
(8, N'43890123', N'Martina', N'Soria', N'3815550108', N'martina.soria@mail.com', DATEADD(DAY, -165, @hoy), 4, 1),
(9, N'35901234', N'Nicolás', N'Vega', N'3815550109', NULL, @hoy, 2, 1),
(10, N'44012345', N'Agustina', N'Ruiz', N'3815550110', N'agus.ruiz@mail.com', DATEADD(DAY, -60, @hoy), 1, 1),
(11, N'34123450', N'Facundo', N'Luna', NULL, NULL, DATEADD(DAY, -220, @hoy), 2, 0),
(12, N'45234561', N'Julieta', N'Medina', N'3815550112', N'juli.medina@mail.com', DATEADD(DAY, -83, @hoy), 3, 1);
SET IDENTITY_INSERT dbo.socio OFF;

-- Cuotas: fecha_vencimiento = fecha_desde + duración - 1 (último día válido)
-- Nicolás (socio 9) se anotó hoy y todavía no pagó ninguna cuota.
-- Agustina (socio 10) pagó hoy, Facundo (socio 11) está dado de baja.
INSERT INTO dbo.cuota (id_socio, id_plan, fecha_pago, fecha_desde, fecha_vencimiento, monto, medio_pago, id_usuario) VALUES
(1, 2, DATEADD(MINUTE, 615, CAST(DATEADD(DAY, -40, @hoy) AS DATETIME)), DATEADD(DAY, -40, @hoy), DATEADD(DAY, -11, @hoy), 25000.00, N'Efectivo', 2),
(1, 2, DATEADD(MINUTE, 615, CAST(DATEADD(DAY, -10, @hoy) AS DATETIME)), DATEADD(DAY, -10, @hoy), DATEADD(DAY, 19, @hoy), 25000.00, N'Transferencia', 2),
(2, 2, DATEADD(MINUTE, 1100, CAST(DATEADD(DAY, -55, @hoy) AS DATETIME)), DATEADD(DAY, -55, @hoy), DATEADD(DAY, -26, @hoy), 25000.00, N'Tarjeta', 1),
(2, 2, DATEADD(MINUTE, 1100, CAST(DATEADD(DAY, -25, @hoy) AS DATETIME)), DATEADD(DAY, -25, @hoy), DATEADD(DAY, 4, @hoy), 25000.00, N'Tarjeta', 1),
(3, 1, DATEADD(MINUTE, 540, CAST(DATEADD(DAY, -27, @hoy) AS DATETIME)), DATEADD(DAY, -27, @hoy), DATEADD(DAY, 2, @hoy), 18000.00, N'Efectivo', 2),
(4, 3, DATEADD(MINUTE, 690, CAST(DATEADD(DAY, -29, @hoy) AS DATETIME)), DATEADD(DAY, -29, @hoy), DATEADD(DAY, 60, @hoy), 65000.00, N'Transferencia', 1),
(5, 2, DATEADD(MINUTE, 1150, CAST(DATEADD(DAY, -34, @hoy) AS DATETIME)), DATEADD(DAY, -34, @hoy), DATEADD(DAY, -5, @hoy), 25000.00, N'Efectivo', 2),
(6, 1, DATEADD(MINUTE, 1065, CAST(DATEADD(DAY, -41, @hoy) AS DATETIME)), DATEADD(DAY, -41, @hoy), DATEADD(DAY, -12, @hoy), 18000.00, N'Mercado Pago', 2),
(7, 2, DATEADD(MINUTE, 520, CAST(DATEADD(DAY, -59, @hoy) AS DATETIME)), DATEADD(DAY, -59, @hoy), DATEADD(DAY, -30, @hoy), 25000.00, N'Efectivo', 1),
(8, 4, DATEADD(MINUTE, 720, CAST(DATEADD(DAY, -165, @hoy) AS DATETIME)), DATEADD(DAY, -165, @hoy), DATEADD(DAY, 199, @hoy), 220000.00, N'Transferencia', 1),
(10, 1, GETDATE(), @hoy, DATEADD(DAY, 29, @hoy), 18000.00, N'Mercado Pago', 2),
(11, 2, DATEADD(MINUTE, 960, CAST(DATEADD(DAY, -119, @hoy) AS DATETIME)), DATEADD(DAY, -119, @hoy), DATEADD(DAY, -90, @hoy), 25000.00, N'Efectivo', 2),
(12, 3, DATEADD(MINUTE, 630, CAST(DATEADD(DAY, -83, @hoy) AS DATETIME)), DATEADD(DAY, -83, @hoy), DATEADD(DAY, 6, @hoy), 65000.00, N'Tarjeta', 1);

INSERT INTO dbo.asistencia (id_socio, fecha_hora, permitido, motivo, id_usuario) VALUES
(1, DATEADD(MINUTE, 1120, CAST(DATEADD(DAY, -6, @hoy) AS DATETIME)), 1, N'Ingreso correcto', 1),
(2, DATEADD(MINUTE, 485, CAST(DATEADD(DAY, -6, @hoy) AS DATETIME)), 1, N'Ingreso correcto', 2),
(4, DATEADD(MINUTE, 740, CAST(DATEADD(DAY, -6, @hoy) AS DATETIME)), 1, N'Ingreso correcto', 1),
(8, DATEADD(MINUTE, 1195, CAST(DATEADD(DAY, -6, @hoy) AS DATETIME)), 1, N'Ingreso correcto', 2),
(12, DATEADD(MINUTE, 570, CAST(DATEADD(DAY, -6, @hoy) AS DATETIME)), 1, N'Ingreso correcto', 1),
(1, DATEADD(MINUTE, 1035, CAST(DATEADD(DAY, -5, @hoy) AS DATETIME)), 1, N'Ingreso correcto', 1),
(3, DATEADD(MINUTE, 430, CAST(DATEADD(DAY, -5, @hoy) AS DATETIME)), 1, N'Ingreso correcto', 2),
(4, DATEADD(MINUTE, 645, CAST(DATEADD(DAY, -5, @hoy) AS DATETIME)), 1, N'Ingreso correcto', 1),
(8, DATEADD(MINUTE, 1120, CAST(DATEADD(DAY, -5, @hoy) AS DATETIME)), 1, N'Ingreso correcto', 2),
(1, DATEADD(MINUTE, 740, CAST(DATEADD(DAY, -4, @hoy) AS DATETIME)), 1, N'Ingreso correcto', 1),
(2, DATEADD(MINUTE, 1195, CAST(DATEADD(DAY, -4, @hoy) AS DATETIME)), 1, N'Ingreso correcto', 2),
(3, DATEADD(MINUTE, 570, CAST(DATEADD(DAY, -4, @hoy) AS DATETIME)), 1, N'Ingreso correcto', 1),
(4, DATEADD(MINUTE, 1035, CAST(DATEADD(DAY, -4, @hoy) AS DATETIME)), 1, N'Ingreso correcto', 2),
(8, DATEADD(MINUTE, 430, CAST(DATEADD(DAY, -4, @hoy) AS DATETIME)), 1, N'Ingreso correcto', 1),
(12, DATEADD(MINUTE, 645, CAST(DATEADD(DAY, -4, @hoy) AS DATETIME)), 1, N'Ingreso correcto', 2),
(1, DATEADD(MINUTE, 645, CAST(DATEADD(DAY, -3, @hoy) AS DATETIME)), 1, N'Ingreso correcto', 1),
(4, DATEADD(MINUTE, 1120, CAST(DATEADD(DAY, -3, @hoy) AS DATETIME)), 1, N'Ingreso correcto', 2),
(8, DATEADD(MINUTE, 485, CAST(DATEADD(DAY, -3, @hoy) AS DATETIME)), 1, N'Ingreso correcto', 1),
(1, DATEADD(MINUTE, 570, CAST(DATEADD(DAY, -2, @hoy) AS DATETIME)), 1, N'Ingreso correcto', 1),
(2, DATEADD(MINUTE, 1035, CAST(DATEADD(DAY, -2, @hoy) AS DATETIME)), 1, N'Ingreso correcto', 2),
(3, DATEADD(MINUTE, 430, CAST(DATEADD(DAY, -2, @hoy) AS DATETIME)), 1, N'Ingreso correcto', 1),
(4, DATEADD(MINUTE, 645, CAST(DATEADD(DAY, -2, @hoy) AS DATETIME)), 1, N'Ingreso correcto', 2),
(8, DATEADD(MINUTE, 1120, CAST(DATEADD(DAY, -2, @hoy) AS DATETIME)), 1, N'Ingreso correcto', 1),
(12, DATEADD(MINUTE, 485, CAST(DATEADD(DAY, -2, @hoy) AS DATETIME)), 1, N'Ingreso correcto', 2),
(1, DATEADD(MINUTE, 485, CAST(DATEADD(DAY, -1, @hoy) AS DATETIME)), 1, N'Ingreso correcto', 1),
(2, DATEADD(MINUTE, 740, CAST(DATEADD(DAY, -1, @hoy) AS DATETIME)), 1, N'Ingreso correcto', 2),
(3, DATEADD(MINUTE, 1195, CAST(DATEADD(DAY, -1, @hoy) AS DATETIME)), 1, N'Ingreso correcto', 1),
(4, DATEADD(MINUTE, 570, CAST(DATEADD(DAY, -1, @hoy) AS DATETIME)), 1, N'Ingreso correcto', 2),
(8, DATEADD(MINUTE, 1035, CAST(DATEADD(DAY, -1, @hoy) AS DATETIME)), 1, N'Ingreso correcto', 1),
(12, DATEADD(MINUTE, 430, CAST(DATEADD(DAY, -1, @hoy) AS DATETIME)), 1, N'Ingreso correcto', 2),
(4, DATEADD(MINUTE, 430, CAST(@hoy AS DATETIME)), 1, N'Ingreso correcto', 1),
(8, DATEADD(MINUTE, 645, CAST(@hoy AS DATETIME)), 1, N'Ingreso correcto', 2),
(5, DATEADD(MINUTE, 665, CAST(DATEADD(DAY, -2, @hoy) AS DATETIME)), 0, N'Cuota vencida', 2),
(6, DATEADD(MINUTE, 665, CAST(DATEADD(DAY, -1, @hoy) AS DATETIME)), 0, N'Cuota vencida', 2),
(7, DATEADD(MINUTE, 665, CAST(DATEADD(DAY, -1, @hoy) AS DATETIME)), 0, N'Cuota vencida', 2),
(5, DATEADD(MINUTE, 665, CAST(@hoy AS DATETIME)), 0, N'Cuota vencida', 2);
GO

-- =====================================================================
-- Gym Control (SQL Server) - 04: vista que usa la aplicación
-- =====================================================================
USE bd_gimnasio;
GO

IF OBJECT_ID(N'dbo.vw_socio_estado', N'V') IS NOT NULL DROP VIEW dbo.vw_socio_estado;
GO

-- Una VISTA es una consulta guardada con nombre: se usa como si fuera una tabla.
-- Esta vista une cada socio con su plan y calcula DOS datos que no existen como columna:
--   * ultimo_vencimiento: la fecha de vencimiento más alta de sus cuotas (NULL si nunca pagó)
--   * estado_cuota: 'Al día', 'Vencida' o 'Sin cuotas'
CREATE VIEW dbo.vw_socio_estado AS
SELECT  datos.*,
        CASE WHEN datos.ultimo_vencimiento IS NULL THEN N'Sin cuotas'
             WHEN datos.ultimo_vencimiento >= CAST(GETDATE() AS DATE) THEN N'Al día'
             ELSE N'Vencida' END AS estado_cuota,
        CASE WHEN datos.estado = 1 THEN N'Activo' ELSE N'Baja' END AS estado_texto
FROM (
        SELECT  s.id_socio, s.dni, s.nombre, s.apellido, s.telefono, s.email,
                s.fecha_alta, s.id_plan, p.nombre AS nombre_plan, s.estado,
                (SELECT MAX(c.fecha_vencimiento) FROM dbo.cuota c WHERE c.id_socio = s.id_socio) AS ultimo_vencimiento
        FROM    dbo.socio s
        INNER JOIN dbo.plan_membresia p ON p.id_plan = s.id_plan
     ) AS datos;
GO

-- Consulta de ejemplo para mostrar en clase: los morosos
-- SELECT dni, apellido, nombre, ultimo_vencimiento FROM dbo.vw_socio_estado
-- WHERE estado = 1 AND estado_cuota <> N'Al día';

-- =====================================================================
-- Gym Control (SQL Server) - 05: procedimientos almacenados
-- Un procedimiento almacenado (stored procedure) es una consulta guardada en la base con un nombre.
-- La aplicación C# no escribe SQL: solo llama a estos procedimientos y les pasa parámetros.
-- Convención: SP_<Acción><Tema>. Los que modifican datos devuelven @Mensaje (OUTPUT):
--   '' (vacío) = salió bien, cualquier otro texto = el motivo del error.
-- =====================================================================
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
    @Mensaje   NVARCHAR(500) OUTPUT
AS
BEGIN
    SET @Mensaje = ''

    IF EXISTS (SELECT 1 FROM dbo.socio WHERE dni = @Dni)
    BEGIN
        SET @Mensaje = N'Ya existe un socio con ese DNI.'
        RETURN
    END

    INSERT INTO dbo.socio (dni, nombre, apellido, telefono, email, fecha_alta, id_plan, estado)
    VALUES (@Dni, @Nombre, @Apellido, @Telefono, @Email, CAST(GETDATE() AS DATE), @IdPlan, @Estado)
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
