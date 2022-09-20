using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRCA2EX6
{
    class Program
    {
        static void Main(string[] args)
        {
            Milhas milhas;
            milhas = new Milhas();
            Console.Write("Digite o valor das milhas: ");
            milhas.setValormilhas(Double.Parse(Console.ReadLine()));
            milhas.resultado() ;
            Console.WriteLine("{0} milhas equivalem a {1} km",
                 milhas.getValormilhas(), milhas.getValorkm());
        }
    }
}
