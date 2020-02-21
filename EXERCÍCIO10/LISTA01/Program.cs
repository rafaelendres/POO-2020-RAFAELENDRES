using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA01
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;       
            
                double anos = 0, pordia = 0, preco = 0, total = 0;
                Console.WriteLine("INFORME HA QUANTOS ANOS VOCE FUMA:");
                anos = double.Parse(Console.ReadLine());

                Console.WriteLine("INFORME QUANTOS CIGARROS POR DIA:");
                pordia = double.Parse(Console.ReadLine());

                Console.WriteLine("INFORME QUAL O PREÇO DO DA CARTEIRA DE CIGARROS:"); preco = double.Parse(Console.ReadLine());

                total = (((anos * 365) * pordia) * preco/20);
                Console.WriteLine("TOTAL GASTO: {0}", total);
            }
        }
    }
    }
}
