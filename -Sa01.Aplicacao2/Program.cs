using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Sa01.Aplicacao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int AnoVigente, Subtracao = 0;

            Console.WriteLine("Favor escreva ano vigente");

            AnoVigente = int.Parse(Console.ReadLine());

            Subtracao = AnoVigente - 1968;

            Console.WriteLine("O valor do ano é:" + Subtracao);
            Console.ReadLine();




        }
    }
}
