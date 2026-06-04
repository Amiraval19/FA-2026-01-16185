from Cajero import Cajero
c = Cajero()

continuar = "s"

while(continuar == "s"):
    print("-----------------------------------")
    print("-  BIENVENIDOS AL SISTEMA CAJERO  -")
    print("-----------------------------------")
    print("1.   Consultar saldo ")
    print("2.   Depositar dinero")
    print("3.   Retirar dinero  ")
    print("4.   Salir           ")
    print()
    
    while(True):
        opcion = int(input("Ingrese una opcion (1-4) :"))
        if opcion in(1,2,3,4):
            break
        else:
            print("Error. Opcion no valida")
            print()
    match opcion:
        case 1: 
            print()
            print(f"Tu saldo es : S/" , c.Consultar())

        case 2:
            while(True):
                try:
                    monto = float(input("Ingrese el monto a depositar : S/"))
                    if(monto > 0):
                      c.Depositar(monto)
                      break
                    else:
                      print("Error. Solo se permiten positivos")
                      
                except ValueError:
                    print("Error. Solo se permiten numeros validos")

        case 3:
            print()

        case 4:
            exit()

    while(True):
        continuar = input("¿Desea continuar? Presione [S] o para salir [N] :").lower()
        if continuar in ("s","n"):
            break
        else:
            print("Error. Solo se permite S o N")
        
