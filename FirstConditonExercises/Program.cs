using System;

namespace FirstConditonExercises
{
  class Program
  {
    static void Main(string[] args)
    {
      string input = null;
      int enteredNumber;
      while (input == null)
      {
        Console.Write("Please, enter a number : ");
        input = Console.ReadLine();
        try {
          enteredNumber = int.Parse(input);
          if (enteredNumber >= 1 && enteredNumber <= 10)
          {
            Console.WriteLine("Valid");
            break;
          }
          else throw new Exception("The provided value is too high !");
        } catch (Exception) {
          Console.WriteLine("Not Valid");
          input = null;
          System.Threading.Thread.Sleep(1000);
          Console.Clear();
        }
      }
    }
  }
}
