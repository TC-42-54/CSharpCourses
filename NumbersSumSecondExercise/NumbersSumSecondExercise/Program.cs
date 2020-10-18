using System;

namespace NumbersSumSecondExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            while (true)
            {
                try
                {
                    Console.Write("Enter a number or 'ok' to exit : ");
                    string input = Console.ReadLine();
                    if (input == "ok")
                    {
                        Console.WriteLine("The sum of the entered numbers is : {0}", sum);
                        break;
                    }
                    sum += int.Parse(input);
                } catch(Exception)
                {
                    continue;
                }
            }
        }
    }
}
