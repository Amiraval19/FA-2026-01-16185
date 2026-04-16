using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3_C
{
    internal class ejer3
    {
        static void Main(string[] args)
        {
            /*int num1, num2;
            double resta, suma, division, multi;

            Console.Write("Ingrese numero 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese numero 1: ");
            num2 = int.Parse(Console.ReadLine());

            suma = num1 + num2;
            resta = num1 - num2;
            division = num1 / num2;
            multi = num1 * num2;

            Console.WriteLine();
            Console.WriteLine("Resultados :");
            Console.WriteLine("La suma entre {0} y {1} es : {2}",num1, num2,suma);
            Console.WriteLine("La resta entre {0} y {1} es : {2}",num1, num2,resta);
            Console.WriteLine("La multiplicacion entre {0} y {1} es : {2}",num1, num2,multi);
            Console.WriteLine("La division entre {0} y {1} es : {2}",num1, num2,division); */

            Console.Write("Ingrese numero 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese numero 2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nSuma: " + (num1 + num2));
            Console.WriteLine("\nResta: " + (num1 - num2));
            Console.WriteLine("\nMultiplicacion: " + (num1 * num2));
            Console.WriteLine("\nDivision: " + (double)(num1 / num2 ));
            Console.ReadKey();

        }
    }
}
