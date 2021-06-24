using System;

namespace _2_area_circulo
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            double radius;
            radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("A=" + ( pi * Math.Pow(radius, 2)).ToString("0.0000"));
        }
    }
}
