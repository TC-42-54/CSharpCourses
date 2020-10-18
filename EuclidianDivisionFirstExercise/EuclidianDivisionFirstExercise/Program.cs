using System;

namespace EuclidianDivisionFirstExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i < 100; i++)
            {
                if ((i % 3) == 0)
                    count++;
            }
            Console.WriteLine("There are {0} numbers that are divisble by 3 with no remainder.", count);
        }
    }
}
