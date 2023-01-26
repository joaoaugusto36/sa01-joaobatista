using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Sa01.Aplicacao4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal Valor, Clientes,Divisao;
              
            Console.WriteLine("Valor a ser dividido ?:");

            Valor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quantidade de clientes especiais:");

            Clientes = Convert.ToInt32(Console.ReadLine());

            Divisao = Valor / Clientes;

            Console.WriteLine("A Divisão do valor entre os clientes especiais são: " + Divisao);
            Console.ReadLine();





        }
    }
}
