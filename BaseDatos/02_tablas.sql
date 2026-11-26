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
