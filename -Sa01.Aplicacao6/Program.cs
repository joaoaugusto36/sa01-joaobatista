using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Sa01.Aplicacao6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int QuantidadeAviao1, QuantidadeAviao2;
            decimal Valor1,Valor2,ValorUnitario1,ValorUnitario2,Frota;

            Console.WriteLine("Quantos Aviões ?");
            QuantidadeAviao1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor ?");
            Valor1 =  int.Parse(Console.ReadLine());

            ValorUnitario1 = QuantidadeAviao1 * Valor1;
           // Console.WriteLine("O valor unitário é:" +ValorUnitario1);


            Console.WriteLine("Quantos Aviões ?");
            QuantidadeAviao2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor ?");
            Valor2 = int.Parse(Console.ReadLine());

            ValorUnitario2 = QuantidadeAviao2 * Valor2;
            
            Frota = ValorUnitario1 + ValorUnitario2;
            Console.WriteLine("O valor da frota é:"+ Frota);
            Console.ReadLine();
        }
    }
}
