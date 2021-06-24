using System;

namespace _5_conversao_tempo
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeInSeconds = int.Parse(Console.ReadLine());
            int hours = timeInSeconds / 3600;
            timeInSeconds = timeInSeconds % 3600; ;
            int minutes = timeInSeconds / 60;
            int seconds = timeInSeconds % 60;

            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }
}
