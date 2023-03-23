using System;
using System.Threading;

namespace Stopwatch
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
            Console.WriteLine("<S> - Seconds => 10s = 10 seconds");
            Console.WriteLine("<M> - Minutes => 1m = 1 minute");
            Console.WriteLine("<E> - Exit");
            Console.WriteLine("Set the limit for the Stopwatch");

            string data = Console.ReadLine().ToLower();

            if (data == "e")
                System.Environment.Exit(0);

            if (data.Length < 2)
            {
                Console.WriteLine("Informar tempo limite de acordo com as instruções.");
                Thread.Sleep(2500);
                Menu();
            }

            char type = char.Parse(data.Substring(data.Length - 1, 1));

            //Verifica se o usuário indicou se o número é minuto ou segundo.
            if (type != 's' && type != 'm')
            {
                Console.WriteLine("É necesário declarar o limite em segundos (s) ou minutos (m) ao definir o tempo do stopwatch.");
                Thread.Sleep(2500);
                Menu();
            }

            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            //Verificação se a variável time é maior do que 0.
            if (time <= 0)
            {
                Console.WriteLine("O limite de contagem do Stopwatch precisa ser maior do que 0s");
                Thread.Sleep(2500);
                Menu();
            }
                

            PreStart(time * multiplier);
        }
        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go!");

            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finished!");
            Thread.Sleep(2500);
            Menu();
        }
    }
}