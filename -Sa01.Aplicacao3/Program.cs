﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Sa01.Aplicacao3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int QuantAviao, multiplicacao = 0;

            Console.WriteLine("Quantidade de aviôes ?");

            QuantAviao=int.Parse(Console.ReadLine());

            multiplicacao = 17 * QuantAviao;
            Console.WriteLine("Quantidade de assentos:" + multiplicacao);
            Console.ReadLine();





        }
    }
}
