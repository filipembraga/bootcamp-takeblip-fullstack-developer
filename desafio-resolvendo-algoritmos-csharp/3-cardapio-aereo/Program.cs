using System;

namespace _3_cardapio_aereo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numberOfMealsAvailableLine = Console.ReadLine().Split(' ');
            string[] numberOfOrdersLine = Console.ReadLine().Split(' ');
            int peopleWithoutMeals = 0;

            for(int x = 0; x<numberOfMealsAvailableLine.Length; x++){
                int numberOfMealsAvailable = int.Parse(numberOfMealsAvailableLine[x]);
                int numberOfOrders = int.Parse(numberOfOrdersLine[x]);

                if (numberOfMealsAvailable < numberOfOrders){
                    peopleWithoutMeals += (numberOfOrders-numberOfMealsAvailable);
                }
            }
            Console.WriteLine("{0}", peopleWithoutMeals);

        }
    }
}
