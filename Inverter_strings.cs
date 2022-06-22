using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] pilha = new char[MAX];
            int topo = 0;
            int i = 0;
            string frase, novaFrase;
            novaFrase = "";

            Console.WriteLine("------ Inverter Strings ------");
            Console.Write("Digite uma frase: ");
            frase = Console.ReadLine();

            int tamanho = frase.Length;

            while (i < tamanho)
            {
                while (i < tamanho && frase[i] != ' ')
                {
                    Insere(pilha, ref topo, frase[i]);
                    i++;
                }
                while (EstaVazia(topo) == false)
                {
                    novaFrase += Remove(pilha, ref topo);
                }
                novaFrase += ' ';
                i++;
            }
            Console.Write("\nSua frase invertida: " + novaFrase);
            Console.ReadKey();
        }

        const int MAX = 20;

        static void Insere(char[] p, ref int t, char v)
        {
            p[t] = v;
            t = t + 1;
        }

        static char Remove(char[] p, ref int t)
        {
            t = t - 1;
            return (p[t]);
        }

        static bool EstaVazia(int t)
        {
            if (t == 0)
                return true;
            else
                return false;
        }

    }
}
