using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SE7_C
{
    internal class ejer2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************************************************");
            Console.WriteLine("            BIENVENIDO AL JUEGO ADIVINADOR        ");
            Console.WriteLine("*******************************************************");

            Console.WriteLine("Instrucciones: ");
            Console.WriteLine("1- El numero a adivinar esta en el rango de 1-20 ");
            Console.WriteLine("2- Ud. tiene 3 intentos ");
            Console.WriteLine("3- Ud. vera un mensaje de apoyo por cada intento fallido\n");

            int intentos = 3;
            int num;
            Random rand = new Random();
            int aleatorio = rand.Next(1,21);
            do
            {
                Console.Write("Ingrese un numero :");
                num = int.Parse(Console.ReadLine());

                if (num == aleatorio)
                {
                    Console.WriteLine("Felicidades, usted adivino el numero :" + num);
                    break;
                }
                else if (num > aleatorio)
                {
                       Console.WriteLine($"El numero a adivinar es menor. Te quedan {intentos - 1} intentos\n");
                    intentos--;
                }
                else 
                {
                    Console.WriteLine($"El numero a adivinar es mayor. Te quedan {intentos - 1} intentos\n");
                    intentos--;
                }

                
            }
            while (intentos < 0);

            if (intentos == 0)
            {
                Console.WriteLine($"El numero aleatorio es :  {num}");
            }


        }
    }
}
