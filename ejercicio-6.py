ana_torres = 0
carlos_mendoza = 0
lucia_paredes = 0
nulos = 0

print("---------- VOTOS ----------")
print("candidatos")
print("1. Ana Torres")
print("2. Carlos Mendoza")
print("3. Lucía Paredes")
print("0. Cerrar votación")

voto = int(input("ingrese su voto ------> : "))

while voto != 0:
    if voto == 1:
        print("voto para Ana Torres")
        ana_torres += 1
    elif voto == 2:
        print("voto para Carlos Mendoza")
        carlos_mendoza += 1
    elif voto == 3:
        print("voto para Lucia Paredes")
        lucia_paredes += 1
    else:
        print("voto nulo")
        nulos += 1

    voto = int(input("ingrese su voto ------> : "))

total_votos = ana_torres + carlos_mendoza + lucia_paredes + nulos

print(f"votos de Ana Torres {ana_torres}")
print(f"votos de Carlos Mendoza {carlos_mendoza}")
print(f"votos de Lucía Paredes {lucia_paredes}")
print(f"votos nulos {nulos}")
print(f"total de votantes {total_votos}")

if ana_torres > carlos_mendoza and ana_torres > lucia_paredes:
    print("ganadora es Ana Torres")
elif carlos_mendoza > ana_torres and carlos_mendoza > lucia_paredes:
    print("ganador es Carlos Mendoza")
elif lucia_paredes > ana_torres and lucia_paredes > carlos_mendoza:
    print("ganadora es Lucia Paredes")
else:
    print("empate no hay ganadores")

input("Presiona Enter para salir...")