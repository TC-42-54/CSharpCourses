using System;

namespace UserInput
{
  class CUserInput
  {
    public static void ReadNumberFromConsole(ref int valueToProvide)
    {
      string input = null;
      int enteredNumber;
      while (input == null)
      {
        input = Console.ReadLine();
        try
        {
          enteredNumber = int.Parse(input);
          valueToProvide = enteredNumber;
          break;
        }
        catch (Exception)
        {
          Console.WriteLine("Please enter a valid value");
          input = null;
          System.Threading.Thread.Sleep(1000);
        }
      }
    }
  }
}
