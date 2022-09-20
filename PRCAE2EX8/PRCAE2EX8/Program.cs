using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRCAE2EX8
{
    class Program
    {
        static void Main(string[] args)
        {
            Numeros numero;
            numero = new Numeros();
            Console.Write("Digite o primeiro número: ");
            numero.setN1(int.Parse(Console.ReadLine()));
            Console.Write("Digite o segunda número: ");
            numero.setN2(int.Parse(Console.ReadLine()));
            if (numero.getN1() > numero.getN2())
            {
                Console.WriteLine("o maior valor é {0}",
                    numero.getN1());
            }
             else if (numero.getN2() > numero.getN1())
            {
                Console.WriteLine("o maior valor é {0}",
                    numero.getN2());
            }
        }

    }
}
