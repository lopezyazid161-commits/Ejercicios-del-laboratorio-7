# Configuración inicial
CONTRASEÑA_CORRECTA = "UPN2026"
MAX_INTENTOS = 3

intentos = 0  # Contador de intentos
acceso_concedido = False  # Bandera lógica

# Simulando la estructura Hacer Mientras (do-while)
while True:
    # Se ejecuta al menos una vez
    contraseña_ingresada = input("Ingrese su contraseña: ")
    intentos += 1  # Incrementamos el contador

    # Validación de la contraseña
    if contraseña_ingresada == CONTRASEÑA_CORRECTA:
        acceso_concedido = True
        break  # Rompe el bucle si es correcta

    # Condición compuesta oculta: evaluar si ya no quedan intentos
    if intentos >= MAX_INTENTOS:
        break  # Rompe el bucle si se agotaron los intentos
    else:
        # Muestra los intentos restantes
        intentos_restantes = MAX_INTENTOS - intentos
        print(
            f"Contraseña incorrecta. Te quedan {intentos_restantes} intentos."
        )

# Mensajes finales basados en la bandera lógica
if acceso_concedido:
    print("\nAcceso concedido. Bienvenido.")
else:
    print("\nCuenta bloqueada. Contacte al administrador.")