import random

puntaje_jugador = 0
puntaje_pc = 0
ronda = 0

while puntaje_jugador != 300 and puntaje_pc != 300:
    ronda += 1
    print(f"*------ RONDA {ronda} --------*")
    print("elige tu arma")
    print("1. papel")
    print("2. tijera")
    print("3. piedra")

    arma = int(input("ingresar numero ----> : "))

    pc = random.randint(1, 3)
    print(f"la PC eligió {pc}")

    if arma < 1 or arma > 3:
        print("arma invalida. la ronda se anula")
        ronda -= 1
    elif arma == pc:
        print("empate")
    elif (arma == 1 and pc == 3) or (arma == 2 and pc == 1) or (arma == 3 and pc == 2):
        print("GANA EL JUGADOR")
        print("ganaste 100 puntos !!!")
        puntaje_jugador += 100
    else:
        print("GANA PC")
        print("PC gana 100 puntos !!!")
        puntaje_pc += 100

    print(f"marcador --- TU puntaje {puntaje_jugador} ----- puntaje de PC {puntaje_pc}")

# resultado final
if puntaje_jugador == 300:
    print("GANASTE :3")
else:
    print("GANO LA PC :C")
