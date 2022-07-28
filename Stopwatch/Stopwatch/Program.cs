using System;
using System.Threading;

namespace Stopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
            }
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo");
            Console.WriteLine("M = Minuto");
            Console.WriteLine("0 = Sair");

            Console.WriteLine("Quanto tempo deseja contar?");
            string option = Console.ReadLine().ToLower(); 
            Console.WriteLine(option);

            if(option == "0")
            {
                System.Environment.Exit(0);
                return;
            }

            char type = char.Parse(option.Substring(option.Length - 1, 1));

            int time = int.Parse(option.Substring(0, option.Length - 1));

            int multiplier = 1;

            if(type == 'm')
            {
                multiplier = 60;
            }

            if(time == 0)
            {
                System.Environment.Exit(0); 

                return;
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

            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
        }

        static void Start(int time)
        { 
            int currentTime = 0;

            while(currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);

                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado!!");
            Thread.Sleep(2500);
        }
    }
}
