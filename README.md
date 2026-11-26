# Gym Control - Sistema de gestión de gimnasio (versión básica)

Aplicación de escritorio en **C# (Windows Forms, .NET Framework 4.8)** con base de datos **SQL Server** y **procedimientos almacenados**. Está organizada en 4 capas y tiene 4 pantallas.

## Estructura

```
SistemaGimnasio.sln
├── CapaEntidad        Clases con los datos (Socio, Plan, Cuota, Usuario...)
├── CapaDatos          Llama a los procedimientos almacenados (clases CD_...)
├── CapaNegocio        Validaciones y reglas (clases CN_...)
├── CapaPresentacion   Las 4 pantallas (formularios)
├── BaseDatos          Scripts SQL (tablas, vista y procedimientos)
└── Documentacion      Mapa del código, reglas y modelo de datos
```

## Cómo ponerlo a andar

1. En **SSMS** abrí `BaseDatos/00_instalar_todo.sql` y ejecutalo con **F5** (sin texto seleccionado). Crea la base `bd_gimnasio` con tablas, datos de prueba, la vista y los 19 procedimientos almacenados.
2. Verificá en `CapaPresentacion/app.config` que `Data Source` sea el servidor que usás en SSMS (por defecto `(localdb)\MSSQLLocalDB`).
3. Abrí `SistemaGimnasio.sln` en Visual Studio, dejá **CapaPresentacion** como proyecto de inicio y ejecutá con **F5**.

## Usuarios de prueba

| Rol | Documento | Clave |
|---|---|---|
| Administrador | 10000001 | admin123 |
| Recepcionista | 10000002 | recep123 |

## Las 4 pantallas

1. **Login** (usuarios con roles).
2. **Inicio**: tarjetas con números, gráfico de ingresos y listas de morosos y vencimientos.
3. **Socios y planes**: alta, modificación y baja de socios y de planes (la pestaña Planes solo la ve el administrador).
4. **Cuotas e ingreso**: control de ingreso (verde = puede entrar, rojo = no) y cobro de cuotas.

## Ver y editar las pantallas

Cada pantalla tiene dos archivos: `frmX.cs` (qué hace cada botón) y `frmX.Designer.cs` (el diseño). Clic derecho sobre `frmX.cs` > **Ver diseñador** (o `Shift+F7`). Doble clic sobre un botón abre su código.

## Si algo falla

- *No se pudo conectar con la base de datos*: SQL Server no está iniciado o el `Data Source` de app.config no coincide con el de SSMS.
- *Cannot open database 'bd_gimnasio'* o *Invalid object name*: falta ejecutar `00_instalar_todo.sql`.
- *Could not find stored procedure 'SP_...'*: falta ejecutar el script `05_procedimientos_almacenados.sql` (o el 00 completo).
- Volver a ejecutar `00_instalar_todo.sql` reinicia todos los datos.
