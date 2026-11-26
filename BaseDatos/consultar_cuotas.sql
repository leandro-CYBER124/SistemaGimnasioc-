-- Consulta para ver los socios y sus cuotas
USE bd_gimnasio;
GO

SELECT 
	s.id_socio,
	s.dni,
	s.apellido + ', ' + s.nombre AS socio,
	s.fecha_alta,
	p.nombre AS plan,
	p.duracion_dias,
	c.fecha_vencimiento,
	c.fecha_pago,
	c.medio_pago,
	COUNT(c.id_cuota) AS total_cuotas
FROM dbo.socio s
LEFT JOIN dbo.plan_membresia p ON s.id_plan = p.id_plan
LEFT JOIN dbo.cuota c ON s.id_socio = c.id_socio
GROUP BY s.id_socio, s.dni, s.apellido, s.nombre, s.fecha_alta, p.nombre, p.duracion_dias, c.fecha_vencimiento, c.fecha_pago, c.medio_pago
ORDER BY s.apellido, s.nombre;
GO

-- Consulta específica para ver socios sin cuotas
SELECT 
	s.id_socio,
	s.dni,
	s.apellido + ', ' + s.nombre AS socio,
	s.fecha_alta,
	p.nombre AS plan,
	COUNT(c.id_cuota) AS total_cuotas
FROM dbo.socio s
LEFT JOIN dbo.plan_membresia p ON s.id_plan = p.id_plan
LEFT JOIN dbo.cuota c ON s.id_socio = c.id_socio
GROUP BY s.id_socio, s.dni, s.apellido, s.nombre, s.fecha_alta, p.nombre
HAVING COUNT(c.id_cuota) = 0
ORDER BY s.apellido, s.nombre;
