using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Rectangulo
    {
        public int Area()
        {
            Console.Write("Ingrese el lado menor:\n");
            int lmenor = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el lado mayor:\n");
            int lmayor = int.Parse(Console.ReadLine());

            return lmenor * lmayor;
        }
        public int Perimetro()
        {
            Console.Write("Ingrese el lado menor:\n");
            int lmenor = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el lado mayor:\n");
            int lmayor = int.Parse(Console.ReadLine());

            return lmenor + lmayor;
        }
    }
}
