using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE5_C
{
    internal class ejer1
    {
        static void Main(string[] args)
        {
            int edad;
            Console.Write("Edad :");
            edad = int.Parse(Console.ReadLine());
            if (edad < 18)
            {
                Console.WriteLine("\nMenor de edad ");
            }
            else if (edad <= 64)
            {
                Console.WriteLine("\nMayor de edad");
            }
            else
            {
                Console.WriteLine("\nAdulto mayor");
            }


        }
    }
}
