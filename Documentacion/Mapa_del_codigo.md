# Mapa del código

## Las 4 capas (cada una solo le habla a la de abajo)

```
Pantalla (CapaPresentacion)  ->  Negocio (CapaNegocio)  ->  Datos (CapaDatos)  ->  SQL Server
 frmXxx.cs                       CN_Xxx.cs                  CD_Xxx.cs              procedimientos SP_Xxx
 botones y cuadros               validaciones y reglas      llama al procedimiento tablas y vista
                 CapaEntidad: Socio, Plan, Cuota, Usuario... (las "cajas de datos" que viajan entre capas)
```

- La **pantalla** nunca escribe SQL ni decide reglas: pide todo a Negocio y muestra el resultado.
- **Negocio** valida y decide (por ejemplo, si un socio puede entrar). No conoce botones ni SQL.
- **Datos** solo llama a los procedimientos almacenados con `Conexion`.
- **SQL Server** guarda los datos y ejecuta los procedimientos.

## Archivos

| Capa | Archivos | Para qué sirven |
|---|---|---|
| CapaEntidad | Usuario, Plan, Socio, Cuota, ResultadoIngreso, ResumenDashboard | Una clase por tabla o respuesta |
| CapaDatos | Conexion | Se conecta a SQL Server y ejecuta procedimientos |
| CapaDatos | CD_Usuario, CD_Plan, CD_Socio, CD_Cuota, CD_Asistencia, CD_Dashboard | Un método por cada procedimiento almacenado |
| CapaNegocio | Seguridad | Convierte la clave en hash SHA-256 |
| CapaNegocio | CN_Usuario, CN_Plan, CN_Socio, CN_Cuota, CN_Asistencia, CN_Dashboard | Validaciones y reglas |
| CapaPresentacion | Program, Sesion, Tema | Arranque, usuario que inició sesión, colores |
| CapaPresentacion | frmLogin, frmInicio, frmSocios, frmCuotas | Las 4 pantallas |

## Procedimientos almacenados (script 05)

| Tema | Procedimientos |
|---|---|
| Usuarios | SP_ObtenerUsuario |
| Planes | SP_ListarPlanes, SP_ObtenerPlan, SP_RegistrarPlan, SP_EditarPlan |
| Socios | SP_ListarSocios, SP_ObtenerSocioPorId, SP_ObtenerSocioPorDni, SP_RegistrarSocio, SP_EditarSocio, SP_CambiarEstadoSocio |
| Cuotas | SP_RegistrarCuota, SP_ListarCuotasSocio |
| Asistencias | SP_RegistrarAsistencia, SP_ListarAsistenciasHoy |
| Dashboard | SP_ResumenDashboard, SP_ListarMorosos, SP_ListarPorVencer, SP_IngresosPorDia |

Los que registran o editan tienen un parámetro de salida `@Mensaje`: queda vacío si salió bien o con el motivo del error (por ejemplo, «Ya existe un socio con ese DNI.»).

## Qué pasa cuando...

**Se inicia sesión:** `frmLogin.btnIngresar_Click` -> `CN_Usuario.Login` -> `CD_Usuario.ObtenerPorDocumento` -> `SP_ObtenerUsuario`. Negocio calcula el hash de la clave escrita y lo compara con el guardado.

**Se guarda un socio:** `frmSocios.btnGuardarSocio_Click` -> `CN_Socio.Guardar` (valida) -> `CD_Socio.Registrar` o `Editar` -> `SP_RegistrarSocio` o `SP_EditarSocio`. Si el DNI está repetido, el procedimiento devuelve el mensaje.

**Se controla un ingreso:** `frmCuotas.btnVerificar_Click` -> `CN_Asistencia.RegistrarIngreso` (existe, está activo, cuota no vencida) -> `SP_RegistrarAsistencia`.

**Se cobra una cuota:** `frmCuotas.btnCobrar_Click` -> `CN_Cuota.Cobrar` -> `CD_Cuota.Registrar` -> `SP_RegistrarCuota`. El período se calcula antes con `CN_Cuota.Calcular`.

## Prefijos de los controles

txt = cuadro de texto · lbl = etiqueta · btn = botón · cmb = desplegable · chk = casilla · num = número · grid = grilla · col = columna · pnl = panel · tabs = pestañas.
