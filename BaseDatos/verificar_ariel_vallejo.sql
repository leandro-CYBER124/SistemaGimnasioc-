-- Verificar si se creó la cuota para Ariel Vallejo
USE bd_gimnasio;
GO

SELECT 
	s.id_socio,
	s.dni,
	s.apellido,
	s.nombre,
	s.fecha_alta,
	p.nombre AS plan,
	COUNT(c.id_cuota) AS total_cuotas,
	MAX(c.fecha_vencimiento) AS ultimo_vencimiento,
	MAX(c.fecha_pago) AS ultimo_pago
FROM dbo.socio s
LEFT JOIN dbo.plan_membresia p ON s.id_plan = p.id_plan
LEFT JOIN dbo.cuota c ON s.id_socio = c.id_socio
WHERE s.apellido LIKE '%Vallejo%' AND s.nombre LIKE '%Ariel%'
GROUP BY s.id_socio, s.dni, s.apellido, s.nombre, s.fecha_alta, p.nombre;

-- Si el anterior no encuentra nada, busca por apellido
SELECT 
	s.id_socio,
	s.dni,
	s.apellido,
	s.nombre,
	s.fecha_alta,
	p.nombre AS plan,
	COUNT(c.id_cuota) AS total_cuotas,
	MAX(c.fecha_vencimiento) AS ultimo_vencimiento
FROM dbo.socio s
LEFT JOIN dbo.plan_membresia p ON s.id_plan = p.id_plan
LEFT JOIN dbo.cuota c ON s.id_socio = c.id_socio
WHERE s.apellido LIKE '%Vallejo%'
GROUP BY s.id_socio, s.dni, s.apellido, s.nombre, s.fecha_alta, p.nombre
ORDER BY s.nombre;
