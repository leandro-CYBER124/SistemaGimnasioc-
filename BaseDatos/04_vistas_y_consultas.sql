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
