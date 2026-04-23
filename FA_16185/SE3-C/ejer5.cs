using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3_C
{
    internal class ejer5
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero :");
            string num = Console.ReadLine();

            double deci = double.Parse(num);
            int entero = (int)Math.Round(deci, 0);
            

            Console.WriteLine($"\nResto de 2 : {entero % 2}");
            Console.WriteLine($"\nDecimal dividido entre 3 : {deci / 3}");

        }
    }
}
