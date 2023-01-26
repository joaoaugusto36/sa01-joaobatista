using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Sa01.Aplicacao1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, soma;
            Console.WriteLine("Entre com o valor do primeiro avião:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre com o valor do segundo avião:");
            num2 = Convert.ToInt32(Console.ReadLine());
            soma = num1 + num2;
            Console.WriteLine("A soma dos aviões são: " + soma);
            Console.ReadLine();


        }
    }
}
