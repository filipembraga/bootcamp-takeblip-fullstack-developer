using System;

namespace _1_soma_simples
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int SOMA = firstNumber + secondNumber;

            Console.WriteLine("SOMA = {0}", SOMA);
        }
    }
}
