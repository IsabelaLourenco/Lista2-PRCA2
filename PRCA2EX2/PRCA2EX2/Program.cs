using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRCA2EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado quad;
            quad = new Quadrado();
            Console.Write("Digite o valor da aresta do quadrado: ");
            quad.setAresta(int.Parse(Console.ReadLine()));
            quad.resultado();
            Console.WriteLine("a área do quadrado com aresta {0} é {1} ",
                quad.getAresta(), quad.getArea());        
        }
    }
}
