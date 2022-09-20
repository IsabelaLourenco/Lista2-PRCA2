using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRCAEX4
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo tri;
            tri = new Triangulo();
            Console.Write("Digite o valor da base: ");
            tri.setB(int.Parse(Console.ReadLine()));
            Console.Write("Digite o valor da altura: ");
            tri.setH(int.Parse(Console.ReadLine()));
            tri.area();
            Console.WriteLine("A área do triangulo com base {0} e altura {1} é {2} ",
                tri.getB(), tri.getH(), tri.getA());
        }
    }
}
