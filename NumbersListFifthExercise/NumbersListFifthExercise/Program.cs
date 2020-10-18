using System;

namespace NumbersListFifthExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a list of numbers separated by a comma :");
            string input = Console.ReadLine();
            string[] splittedNumbers = input.Split(',');
            int sum = 0;

            foreach (string stringNumber in splittedNumbers)
            {
                try
                {
                    sum += int.Parse(stringNumber);
                }
                catch (Exception)
                {
                    continue;
                }
            }
            Console.WriteLine("The sum of the numbers list entered is : {0}.", sum);
        }
    }
}
