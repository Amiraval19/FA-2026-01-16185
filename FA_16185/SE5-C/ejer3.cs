using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE5_C
{
    internal class ejer3
    {
        static void Main(string[] args)
        {
            double soles, conversion = 0;
            string moneda = "";

            Console.WriteLine("\n-----SISTEMA CONVERSION DE MONEDA --------\n");
            
            Console.WriteLine("Ingrese el monto en soles : ");
            soles = double.Parse(Console.ReadLine());

            Console.WriteLine("***** MENU DE OPCIONES *****");
            Console.WriteLine("* 1.Conversion a dolares   *");
            Console.WriteLine("* 2.Conversion a euros     *");         
            Console.WriteLine("****************************\n");
            Console.Write("Seleccione la opcion :");
            int opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    moneda = "dolares";
                    conversion = soles / 3.40;
                    break;
                case 2:
                    moneda = "euros";

                    conversion = soles / 4.20;
                    break;
                default:
                    Console.WriteLine("\nOpcion Incorrecta.");
                    break;
            }
            Console.WriteLine($"El importe de {soles} soles a {moneda} es : {Math.Round(conversion,1)} {moneda}");
           
        }
    }
}
