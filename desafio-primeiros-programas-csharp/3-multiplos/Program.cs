using System;

namespace _3_multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(' ');
            int firstNumber = int.Parse(values[0]);
            int secondNumber = int.Parse(values[1]);

            if (firstNumber % secondNumber == 0 || secondNumber % firstNumber == 0) {
                Console.WriteLine("Sao Multiplos");
            }
            else {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
