using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE5_C
{
    internal class ejer4
    {
        static void Main(string[] args)
        {
            string formula = " ";
            int opc;
            double areaT = 0;
            string area = " ";
            Console.WriteLine("-----SISTEMA DE CALCULO DE AREAS -----\n");

            Console.WriteLine("Menu de opciones :");
            Console.WriteLine("1. Cuadrado :");
            Console.WriteLine("2. Rectangulo :");
            Console.WriteLine("3. Triangulo :");
            Console.WriteLine("4. Circulo :");
            Console.Write("Ingrese una opcion :");
            opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    area = "Cuadrado";
                   
                    float lado;
                    Console.WriteLine("Ingrese lado :");
                    lado = float.Parse(Console.ReadLine());
                    formula = $"{lado} * {lado}";
                    areaT = lado * lado;
                    break;

                case 2:
                    area = "Rectangulo";
                    float basee; float altura;
                    Console.Write("Ingrese base:");
                    basee = float.Parse(Console.ReadLine());
                    Console.Write("Ingrese altura:");
                    altura = float.Parse(Console.ReadLine());
                    formula = $"{basee} * {altura}";
                    areaT = basee * altura;
                    break;
                case 3:
                    area = "Triangulo";
                    float baseeT; float alturaT;
                    Console.Write("Ingrese base:");
                    baseeT = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese altura:");
                    alturaT = int.Parse(Console.ReadLine());
                    formula = $"({baseeT} * {alturaT})/ 2";
                    areaT = (baseeT * alturaT) / 2;
                    break;
                case 4:
                    float radio;
                    area = "Circulo";
                    Console.WriteLine("Ingrese radio :");
                    radio = float.Parse(Console.ReadLine());
                    formula = $" Pi * {radio} al cuadrado.";
                    areaT = Math.PI * Math.Pow(radio, 2);
                    break;
                default:
                    break;
            }
            Console.WriteLine("\n*****  RESULTADOS ******\n");
            Console.WriteLine($"* Area seleccionada : {Math.Round(areaT,1)}");
            Console.WriteLine($"* Formula : {formula}");
            Console.WriteLine($"* Resultado : {areaT}");


        }
    }
}
