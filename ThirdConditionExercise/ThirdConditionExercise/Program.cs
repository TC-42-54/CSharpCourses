using System;
using UserInput;

namespace ThirdConditionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 0;
            int height = 0;

            Console.Write("Enter the width of your image : ");
            CUserInput.ReadNumberFromConsole(ref width);
            Console.Write("Enter the height of your image : ");
            CUserInput.ReadNumberFromConsole(ref height);

            if (width > height)
            {
                Console.WriteLine("Your image format is landscape.");
            } else
            {
                Console.WriteLine("Your image format is portrait.");
            }
        }
    }
}
