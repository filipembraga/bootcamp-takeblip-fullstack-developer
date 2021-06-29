using System;

namespace _2_coxinha_de_bueno
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputValue = Console.ReadLine().Split(' ');
            double numberOfDrumsticks = double.Parse(inputValue[0]);
            double numberOfPeople = double.Parse(inputValue[1]);

            Console.WriteLine("{0:0.00}",numberOfDrumsticks / numberOfPeople);

        }
    }
}
