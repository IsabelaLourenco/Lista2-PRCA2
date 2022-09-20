using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRCAEX11
{
    class Program
    {
        static void Main(string[] args)
        {
            Peso peso;
            peso = new Peso();
            Console.Write("Digite seu peso: ");
            peso.setPeso(Double.Parse(Console.ReadLine()));
            Console.Write("Digite altura: ");
            peso.setAltura(Double.Parse(Console.ReadLine()));
            peso.indice();
            if (peso.getIMC()<20)
            {
                Console.WriteLine("Você está abaixo do peso");
            }
            else if (20<= peso.getIMC() && peso.getIMC()< 25)
            {
                Console.WriteLine("Você está com o peso ideal");
            }
            else if (peso.getIMC()>25)
            {
                Console.WriteLine("Você está acima do peso");
            }
        }
    }
}
