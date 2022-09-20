using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRCAEX13
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo tri;
            tri = new Triangulo();
            Console.Write("Digite o primerio valor: ");
            tri.setA(int.Parse(Console.ReadLine()));
            Console.Write("Digite o segundo valor: ");
            tri.setB(int.Parse(Console.ReadLine()));
            Console.Write("Digite o terceiro valor: ");
            tri.setC(int.Parse(Console.ReadLine()));
            Console.WriteLine(tri.ehTretangulo() ?
                "é um triangulo retangulo" :
                "não é triangulo retangulo");


        }
    }
}
