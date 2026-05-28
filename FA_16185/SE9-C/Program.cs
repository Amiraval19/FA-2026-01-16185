using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace SE9_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continuar;
            Triangulo t = new Triangulo();
            Rectangulo r = new Rectangulo();
            Cuadrado c = new Cuadrado();
            Trapecio tr = new Trapecio();

            do
            {
                Console.Clear();
                Console.WriteLine("BIENVENIDO AL SISTEMA DE CALCULOS DE FIGURAS GEOMETRICAS\n");
                Console.WriteLine("1. Triangulo");
                Console.WriteLine("2. Rectangulo");
                Console.WriteLine("3. Cuadrado");
                Console.WriteLine("4. Trapecio");
                Console.WriteLine("5. Salir\n");

                Console.Write("Ingrese una opcion:");
                int opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.WriteLine("BIENVENIDO A LA FIGURA TRIANGULO\n");
                        Console.WriteLine("1. Area");
                        Console.WriteLine("2. Perimetro");
                        Console.Write("\nSeleccione una opcion :");
                        int opc2 = int.Parse(Console.ReadLine());
                        switch (opc2)
                        {
                            case 1:t.area();
                                break;
                            case 2:t.perimetro();
                                break;
                            default:
                                break;
                        }
                        
                        break;
                    case 2:
                        Console.WriteLine("BIENVENIDO A LA FIGURA RECTANGULO\n");
                        Console.WriteLine("1. Area");
                        Console.WriteLine("2. Perimetro");
                        Console.Write("\nSeleccione una opcion :");
                        int opc3 = int.Parse(Console.ReadLine());
                        switch (opc3)
                        {
                            case 1:
                                r.Area();
                                break;
                            case 2:
                                r.Perimetro();
                                break;
                            default:
                                break;
                        }

                        break;
                    case 3:
                        Console.WriteLine("BIENVENIDO A LA FIGURA CUADRADO\n");
                        Console.WriteLine("1. Area");
                        Console.WriteLine("2. Perimetro");
                        Console.Write("\nSeleccione una opcion :");
                        int opc4 = int.Parse(Console.ReadLine());
                        switch (opc4)
                        {
                            case 1:
                                t.area();
                                break;
                            case 2:
                                t.perimetro();
                                break;
                            default:
                                break;
                        }
                        break;
                    case 4:
                        Console.WriteLine("BIENVENIDO A LA FIGURA TRAPECIO\n");
                        Console.WriteLine("1. Area");
                        Console.WriteLine("2. Perimetro");
                        Console.Write("\nSeleccione una opcion :");
                        int opc5 = int.Parse(Console.ReadLine());
                        switch (opc5)
                        {
                            case 1:
                                t.area();
                                break;
                            case 2:
                                t.perimetro();
                                break;
                            default:
                                break;
                        }
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalido");
                        break;
                }


                Console.WriteLine("Desea continuar? presione[y]");
                continuar = Console.ReadLine().ToUpper();
            
            }
            while (continuar == "Y");


            
        }
    }
}
