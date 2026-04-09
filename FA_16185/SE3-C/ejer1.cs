using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3_C
{
    internal class ejer1
    {
        static void Main(string[] args)
        {
            string nombre, carrera;

            Console.WriteLine("\nDatos de entrada");
            Console.WriteLine("-----------------------");
            Console.Write("\nIngrese su nombre :");
            nombre = Console.ReadLine();
            Console.Write("\nIngrese su carrera :");
            carrera = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\nDatos de salida");
            Console.WriteLine("-----------------------");

            Console.WriteLine("\n----- IMPRESO CON + -----");
            Console.WriteLine(nombre + ", Bienvenido al curso de Fundamentos de Algoritmos de la carrera " + carrera);
           
            Console.WriteLine("\n----- IMPRESO CON $ -----");
            Console.WriteLine($"{nombre} , Bienvenido al curso de Fundamentos de Algoritmos de la carrera {carrera}");

            Console.WriteLine("\n----- IMPRESO CON {} -----");
            Console.WriteLine("{0}, Bienvenido al curso de Fundamentos de Algoritmos de la carrera {1}" , nombre,carrera);
            Console.ReadKey();
        }
    }
}
