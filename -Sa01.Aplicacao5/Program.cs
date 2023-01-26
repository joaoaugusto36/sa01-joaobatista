using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Sa01.Aplicacao5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double PrimeiroMes, SegundoMes, TerceiroMes, Media;
            Console.WriteLine("Digite o faturamento primeiro mês:");
            PrimeiroMes=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o faturamento segundo mês:");
            SegundoMes = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o faturamento terceiro mês:");
            TerceiroMes = Convert.ToDouble(Console.ReadLine());

            Media = (PrimeiroMes + SegundoMes + TerceiroMes) / 3;

            Console.WriteLine("A média trimestral do faturamento é:" + Media);
            Console.ReadLine();


        }
    }
}
