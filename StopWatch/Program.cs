using System;
using System.Threading;
using static System.Console;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Clear();

            WriteLine("\nS = Segundo => 10s = 10 segundos");
            WriteLine("M = Minuto => 1m = 1 minuto");
            WriteLine("0 = Exit");
            WriteLine("Quanto tempo deseja contar?");

            string data = ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                Environment.Exit(0);

            PreStart(time * multiplier);


        }

        static void PreStart(int time)
        {
            Clear();

            WriteLine("Ready...");
            Thread.Sleep(1000);
            WriteLine("Set...");
            Thread.Sleep(1000);
            WriteLine("GO.....");
            Thread.Sleep(2500);

            Start(time);
        }


        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Clear();
                currentTime++;
                WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Clear();
            WriteLine("StopWatch Finalizado");
            Thread.Sleep(2500);
            Menu();
        }
    }
}
