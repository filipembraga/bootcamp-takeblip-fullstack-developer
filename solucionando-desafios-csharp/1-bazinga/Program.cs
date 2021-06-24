using System;

namespace _1_bazinga
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdTeste = int.Parse(Console.ReadLine());
            string choiceSheldon, choiceRaj;

            for(int i=1; i<=qtdTeste; i++)
            {
                string[] choices = Console.ReadLine().Split(' ');
                choiceSheldon = choices[0].ToLower();
                choiceRaj = choices[1].ToLower();

                if((choiceSheldon=="tesoura" && choiceRaj=="papel") || (choiceSheldon=="papel" && choiceRaj=="pedra")
                    || (choiceSheldon=="pedra" && choiceRaj=="lagarto") || (choiceSheldon=="lagarto" && choiceRaj=="spock")
                    || (choiceSheldon=="spock" && choiceRaj=="tesoura") || (choiceSheldon=="tesoura" && choiceRaj=="lagarto")
                    || (choiceSheldon=="lagarto" && choiceRaj=="papel") || (choiceSheldon=="papel" && choiceRaj=="spock")
                    || (choiceSheldon=="spock" && choiceRaj=="pedra") || (choiceSheldon=="pedra" && choiceRaj=="tesoura"))
                {
                    Console.WriteLine("Caso #{0}: Bazinga!", i);   
                }

                else if (choiceSheldon == choiceRaj)
                {
                    Console.WriteLine("Caso #{0}: De novo!", i);
                }

                else
                {
                    Console.WriteLine("Caso #{0}: Raj trapaceou!", i);                    
                }
            }
        }
    }
}
