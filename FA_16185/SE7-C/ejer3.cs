using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE7_C
{
    internal class ejer3
    {
        static void Main(string[] args) 
        {
            string continuar;
            int num;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese un numero");
                num = int.Parse(Console.ReadLine());
                if (num <= 0)
                {
                    Console.WriteLine("El numero debe de ser mayor a 0!\n");
                }
                else
                {
                    int suma = 0;
                    int i = 1;
                    do
                    {
                        suma += i;
                        i++;
                    }
                    while (i<num);
                    Console.WriteLine($"\nLa suma de los numeros de 1 hasta {num} es {suma} ");
                }
                
                   

                Console.Write("\nDesea continuar? (presione si)");
                continuar = Console.ReadLine();
            }
            while (continuar == "si");
        }
    }
}
