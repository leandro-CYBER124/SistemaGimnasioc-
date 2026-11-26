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
