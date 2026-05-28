from operator import mul


def suma(num1,num2)-> None:
    print("La suma es: ", num1 + num2)
def resta(num1,num2)-> None:
    print("La resta es: ", num1 - num2)
def multi(num1,num2)-> None:
    print("La multiplicacion es: ", num1 * num2)
def divi(num1,num2)-> None:
    if num2 != 0:
        print(f"La division es:" ,num1//num2)
        #// -> es para que la division salga entero
    else:
        print(f"No se puede dividir entre 0")

while(True):
     print(f"BIENVENIDO AL SISTEMA DE CALCULADORA BASICA\n")
     print(f"1. Suma")
     print(f"2. Resta")
     print(f"3. Multipliacion")
     print(f"4. Division")
     print(f"5. Salir")


     opc = int(input("Ingrese una opcion:"))
     if opc >= 1 and opc <= 4:
         num1= int(input("Ingrese numero 1:"))
         num2= int(input("Ingrese numero 2:"))
     match opc:
         case 1:
             suma(num1,num2)
         case 2:
             resta(num1,num2)
         case 3:
             multi(num1,num2)
         case 4:
             divi(num1,num2)
         case 5: exit()
         case _:print(f"\nOpcion no valida!")

     continuar = input("\nDesea continuar= (presione [y])")

     if(continuar != "y"): break

     