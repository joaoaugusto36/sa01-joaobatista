using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Sa01.Aplicacao7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Peca01, Peca02, Peca03, Peca04, Peca05, Total;

            Console.WriteLine("Valor peça número 1:");
            Peca01 = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor peça número 2:");
            Peca02 = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor peça número 3:");
            Peca03 = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor peça número 4:");
            Peca04 = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor peça número 5:");
            Peca05 = int.Parse(Console.ReadLine());

            Total = Peca01 + Peca02 + Peca03 + Peca04 + Peca05;
            Console.WriteLine("O valor total das peças são:" + Total);
            Console.ReadLine(); 
        }
    }
}
