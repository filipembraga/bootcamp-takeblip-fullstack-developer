using System;

namespace _1_formula_bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue, thirdValue, delta, firstRoot, secondRoot;
            string[] value = Console.ReadLine().Split();

            firstValue = Convert.ToDouble(value[0]);
            secondValue = Convert.ToDouble(value[1]);
            thirdValue = Convert.ToDouble(value[2]);

            delta = (Math.Pow(secondValue, 2) - (4 * firstValue * thirdValue));
            firstRoot = (-secondValue + Math.Sqrt(delta)) / (2 * firstValue);
            secondRoot = (-secondValue - Math.Sqrt(delta)) / (2 * firstValue);

            if ( delta >= 0 && firstValue != 0)
            {
                Console.WriteLine("R1 = {0:0.00000}", firstRoot);
                Console.WriteLine("R2 = {0:0.00000}", secondRoot);
            }
            else
            {
                Console.WriteLine("Impossivel calcular");
            }
        }
    }
}
