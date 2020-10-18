using System;

namespace FactorialThirdExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    Console.Write("Enter the number from which we should calculate the factorial : ");
                    string input = Console.ReadLine();
                    int number = int.Parse(input);
                    int factorialResult = 1;
                    for (var i = number; i > 1; i--)
                    {
                        factorialResult *= i;
                    }
                    Console.WriteLine("{0}! = {1}", number, factorialResult);
                    break;
                } catch(Exception)
                {
                    Console.WriteLine("Please enter a number...");
                    continue;
                }

            }
        }
    }
}
