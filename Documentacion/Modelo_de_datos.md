# Modelo de datos - bd_gimnasio (SQL Server)

| Tabla | Qué guarda |
|---|---|
| rol | Administrador y Recepcionista |
| usuario | Quienes inician sesión (documento, clave en hash, rol) |
| plan_membresia | Planes con precio y duración en días |
| socio | Los clientes del gimnasio |
| cuota | Historial de pagos de cada socio |
| asistencia | Ingresos permitidos y denegados |
| vw_socio_estado (vista) | Socio + plan + último vencimiento + estado de la cuota |

Relaciones: un rol tiene muchos usuarios; un plan tiene muchos socios; un socio tiene muchas cuotas y muchas asistencias; un usuario registra cuotas y asistencias.

Scripts de la carpeta BaseDatos: 01 crea la base, 02 las tablas, 03 los datos de prueba, 04 la vista, 05 los procedimientos almacenados y 00 ejecuta todos juntos.
