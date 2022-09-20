using Lista2Ex1PRCA2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex1PRCA2
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret;
            ret = new Retangulo();
            Console.Write("Digite o valor da base: ");
            ret.setB(int.Parse(Console.ReadLine()));
            Console.Write("Digite o valor da altura: ");
            ret.setH(int.Parse(Console.ReadLine()));
            ret.area();
            Console.WriteLine("A área do retângulo com base {0} e altura {1} é {2} ",
                ret.getB(), ret.getH(),ret.getA());


        }
    }
}
