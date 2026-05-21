using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num;
            int par = 0, impar = 0;
            do
            {
                Console.Write("Ingrese numero positivo (negativo para salir)");
                num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    par++;
                }
                if (num % 2 != 0)
                {
                    impar++;
                }
            }
            while (num > 0);

            Console.WriteLine($"Cantidad de pares : {par}");
            Console.WriteLine($"Cantidad de impares : {impar}");


        }
    }
}
