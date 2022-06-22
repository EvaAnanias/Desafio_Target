using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sair = "";

            Console.Write("------ Fibonacci ------");
            Console.WriteLine();

            while (sair != "s")
            {
                Console.WriteLine();
                Console.WriteLine("Insira um número: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine(fib(n));
                Console.WriteLine();
                Console.WriteLine("Deseja sair? " +
                            "\n's' - Para sim" +
                            "\n'n' - Para não");
                sair = Console.ReadLine();
            }
        }
        static int fib(int n)
        {
            if (n == 0 || n == 1)
                return n;
            if (n >= 2)
                return fib(n - 1) + fib(n - 2);
            return 0;
        }
    }
}
