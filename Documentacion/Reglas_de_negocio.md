# Reglas de negocio

## Cuotas
- Estado del socio: **Al día** (la cuota vence hoy o después), **Vencida** o **Sin cuotas**. Lo calcula la vista `vw_socio_estado`.
- Si el socio está al día, la nueva cuota empieza el **día siguiente** a su vencimiento. Si está vencido o nunca pagó, empieza **hoy**.
- La cuota vence a los (duración del plan - 1) días, porque el día de inicio cuenta como el primero.
- El monto es el precio del plan al momento de cobrar.
- No se puede cobrar a un socio dado de baja.

## Ingreso
Puede entrar el socio que **existe**, está **activo** y tiene la cuota **vigente**. Cada intento (permitido o denegado) queda guardado con su motivo.

## Socios y planes
- DNI: 7 u 8 números y sin repetir. Nombre y apellido obligatorios. Hay que elegir un plan activo.
- Plan: nombre sin repetir, precio y duración mayores a cero.
- Las bajas son lógicas (campo `estado`): no se borra nada.

## Usuarios
- La clave se guarda como hash SHA-256.
- El administrador ve la pestaña Planes; el recepcionista no.
