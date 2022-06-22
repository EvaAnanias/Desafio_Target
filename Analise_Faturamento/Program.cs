using Analise_faturamento.Serealização;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Analise_faturamento
{
    internal class Program
    {
        //Abri um comentário só para comunicar a vocês que infelizmente não consegui fazer corretamente a questão 
        //que vocês pediram. Peço desculpas, o que ocorreu foi que ainda não aprendi mexer com dados de tabelas dentro da
        //linguagem de programação, porém fiz o código, apenas não consegui chamar a tabela dentro do código. 

        const int MAX = 20;

        static void Insere(int[] fila, ref int fim, int valor)
        {
            fila[fim] = valor;
            Console.WriteLine("Entrou na posição: " + fim);
            fim = fim + 1;
        }

        static int Remove(int[] fila, ref int inicio)
        {
            return (fila[inicio++]);
        }

        static void Main(string[] args)
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\tabela.json");

            var js = new DataContractJsonSerializer(typeof(List<Tabela>));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            var tab = (List<Tabela>)js.ReadObject(ms);

            Console.WriteLine(tab[0]);
            Console.ReadKey();

            int[] fila = new int[MAX];
            int inicio = 0, fim = 0;
            int n = 0;
            int i = 0;

            Console.WriteLine("Quantos números deseja inserir: ");
            n = int.Parse(Console.ReadLine());

            while (i < n)
            {
                Console.WriteLine("Insira um número: ");
                int num = int.Parse(Console.ReadLine());

                Insere(fila, ref fim, num);
                i++;
            }

            int maior = 0;
            int menor = 0;
            int soma = 0;

            for (i = inicio; i < fim; i++)
            {
                int num = Remove(fila, ref inicio);

                if (i == 0)
                {
                    maior = num;
                    menor = num;
                }
                else
                {
                    if (num > maior)
                    {
                        maior = num;
                    }

                    if (num < menor)
                    {
                        menor = num;
                    }
                }

                soma = soma + num;

            }

            int qnt = soma / n;
            Console.WriteLine("O maior número da fila é: " + maior);
            Console.WriteLine("O menor número da fila é: " + menor);
            Console.WriteLine("A média dos números da fila é de: " + qnt);
            Console.ReadKey();
        }
    }
}
