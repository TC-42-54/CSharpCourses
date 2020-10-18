using System;

namespace GuessNumberFourthExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int tries = 4;
            int randomNumber = random.Next(1, 10);

            while (tries >= 1)
            {
                try
                {
                    Console.Write("Guess the Number : ");
                    string input = Console.ReadLine();
                    int choosedNumber = int.Parse(input);
                    if (choosedNumber == randomNumber)
                    {
                        Console.WriteLine("You win !");
                        break;
                    }
                    tries--;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a number...");
                    continue;
                }
            }
            if (tries == 0)
                Console.WriteLine("You Lost.");
        }
    }
}
