using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRCA2EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado quad;
            quad = new Quadrado();
            Console.Write("Digite o valor da aresta do quadrado: ");
            quad.setDiagonal(int.Parse(Console.ReadLine()));
            quad.resultado();
            Console.WriteLine("a área do quadrado com a diagonal {0} é {1} ",
                quad.getDiagonal(), quad.getArea());
        }
    }
}
