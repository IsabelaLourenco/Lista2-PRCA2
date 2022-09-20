using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRCAEX10
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
            if (ret.getA()>100)
            {
                Console.WriteLine("Terreno grande com area de {0}",
                    ret.getA());
            }
            else if (ret.getA() < 100)
            {
                Console.WriteLine("Terreno pequeno com area de {0}",
                    ret.getA());
            }
            
        }
    }
}
