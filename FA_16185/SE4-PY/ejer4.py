
import math



print("\n ***** SISTEMA DE CALCULO DE AREAS *****")
print("* 1. Cuadrado")
print("* 2. Rectangulo")
print("* 3. Triangulo")
print("* 4. Circulo")
opc = int(input("Seleccione opcion :"))

match opc:
    case 1:
        lado = int(input("Ingrese lado :"))
        area = lado * lado
        formula = print(f"{lado} * {lado}")
        print (f"El area es : area")
    case 2:
        base = float(input("Ingrese base :"))
        altura = float(input("Ingrese altura :"))
        formula = print(f"{base} * {altura}")
        area = base * altura
    case 3:
        base2 = float(input("Ingrese base :"))
        altura2 = float(input("Ingrese altura :"))
        formula = print(f"{base2} * {altura2} / 2")
        area = (base2*altura2)/2
    case 4:
        radio = float(input("Ingrese radio :"))
        formula = print(f"{math.pi} * {radio} al cuadrado")
        area = math.pi * math.pow(radio,2)
    case _:
        print("Opcion invalida.")

print("\n*** RESULTADOS ***\n")
print(f"Formula : {formula}")
print(f"Resultado del area : {area}")