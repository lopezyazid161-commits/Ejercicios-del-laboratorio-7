while True:
    nota = int(input("ingrese nota (0-20): "))
    if nota >= 0 and nota <= 20:
        break
    else:
        print("error: nota debe ser entre 0 y 20.")
       
if nota <= 20  and   nota >= 18:
    print("clasificacion: EXCELENTE")
elif nota <= 17  and  nota >= 14:
    print("clasificacion: REGULAR")
elif nota <= 13 and nota >= 11:
    print("clasicacion: REGULAR")
else: 
    print("clasificacion: DESAPROBADO")
