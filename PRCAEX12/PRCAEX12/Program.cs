using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRCAEX12
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo tri;
            tri = new Triangulo();
            Console.Write("Digite o valor primeiro valor: ");
            tri.setA(int.Parse(Console.ReadLine()));
            Console.Write("Digite o valor segundo lado: ");
            tri.setB(int.Parse(Console.ReadLine()));
            Console.Write("Digite o valor terceiro lado: ");
            tri.setC(int.Parse(Console.ReadLine()));
            Console.WriteLine(tri.ehTriangulo() ? 
                "é um triângulo":
                "não é um triângulo");

            Console.WriteLine(tri.ehEquilatero() ?
                "é um triangulo equilatero" :
                "");
            Console.WriteLine(tri.ehIsoceles() ?
                "é um triangulo isoceles" :
                "");
                
            Console.WriteLine(tri.ehEscaleno() ?
                "é um triângulo escaleno" :
                "");
        } 
    }    
}
