using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Triangulo
    {
        public void area()
        {
            Console.Write("Ingrese la base:");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la altura:");
            int a = int.Parse(Console.ReadLine());

            int area = (b * a) / 2;
            Console.WriteLine($"El area del triangulo es : {area}");
        }
        public void perimetro()
        {
            Console.Write("Ingrese el lado 1:\n");
            int l1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el lado 2:\n");
            int l2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el lado 3:\n");
            int l3 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEl perimetro del troangulo es :" + ( l1 + l2 + l3));
        }
    }
}
