using System;
using System.Threading;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Seja bem-vindo ao Cronomêtro !!");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Quando tempo você deseja contar ?");

            string data = Console.ReadLine().ToLower();
            char tipo = char.Parse(data.Substring(data.Length - 1, 1)); // Pega o ÚLTIMO caractere da string 'data'
            int tempo = int.Parse(data.Substring(0, data.Length - 1)); // Pega a string DESDE o início até o PENÚLTIMO caractere // Exemplo: se data = "10s", ele pega "10" // Depois converte esse valor para inteiro

            int multiplicador = 1;

            if (tipo == 'm')
                multiplicador = 60;

            if (tempo == 0)
                System.Environment.Exit(0);

            PreInicio(tempo * multiplicador);
        }
        static void PreInicio(int time)
        {
            Console.Clear();
            Console.WriteLine("Praparar...");
            Thread.Sleep(1000);
            Console.WriteLine("Apontar...");
            Thread.Sleep(1000);
            Console.WriteLine("Já !!!");
            Thread.Sleep(1000);

            Inicio(time);
        }
        static void Inicio(int time)

        {

            int tempo = time;
            int minutoAtual = 0;

            while (minutoAtual != tempo)
            {
                Console.Clear();

                minutoAtual++;
                Console.WriteLine(minutoAtual);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Cronomêtro Finalizado !");
            Thread.Sleep(2000);
            Menu();
        }
    }
}