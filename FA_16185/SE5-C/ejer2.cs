using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE5_C
{
    internal class ejer2
    {
        static void Main(string[] args)
        {
            int an;
            Console.Write("Anio :");
            an = int.Parse(Console.ReadLine());

            if ((an % 4 == 00 && an % 100 != 0) || an % 400 == 0)
            {
                Console.WriteLine("\nEs bisiesto.");
            }
            else
            {
                Console.WriteLine("\nNo es bisiesto.");
            }

            if (an % 2 == 0)
            {
                Console.WriteLine("\nEs par");
            }
            else
            {
                Console.WriteLine("\nEs impar");
            }


        }
    }
}
