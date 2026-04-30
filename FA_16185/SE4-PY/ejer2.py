an = int(input("Ingrese anio :"))

if (an % 4 == 0 and an % 100 != 0) or an % 400 == 0:
    print(f"El anio {an} es bisiesto")
else:
    print(f"El anio {an} no es bisiesto.")

if (an % 2 == 0):
    print(f"El anio {an} es par.")
else:
    print(f"El anio {an} es impar.")

