using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faturamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double SP = 67836.43;
            double RJ = 36678.66;
            double MG = 29229.88;
            double ES = 27165.48;
            double Outros = 19849.53;

            double soma = SP + RJ + MG + ES + Outros;

            Console.WriteLine("Valor da soma de todos os estados: " + soma);
            Console.WriteLine();

            double Sp = (SP / soma) * 100;
            double Rj = (RJ / soma) * 100;
            double Mg = (MG / soma) * 100;
            double Es = (ES / soma) * 100;
            double outros = (Outros / soma) * 100;


            Console.WriteLine("[SP: " + Math.Round(Sp, 2) + "% ]");
            Console.WriteLine("[RJ: " + Math.Round(Rj, 2) + "% ]");
            Console.WriteLine("[MG: " + Math.Round(Mg, 2) + "% ]");
            Console.WriteLine("[ES: " + Math.Round(Es, 2) + "% ]");
            Console.WriteLine("[Outros: " + Math.Round(outros, 2) + "% ]");
            Console.ReadKey();
        }
    }
}
