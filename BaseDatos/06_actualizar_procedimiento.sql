-- Script para actualizar el procedimiento SP_RegistrarSocio
-- Este script agregar la creación automática de cuota inicial cuando se registra un nuevo socio

USE bd_gimnasio;
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
