using System;
using UserInput;
namespace SecondConditionExercises
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] numbers = new int[2] { 0, 0 };
      int highestValue;
      Console.Write("Enter a first number : ");
      CUserInput.ReadNumberFromConsole(ref numbers[0]);
      Console.Write("Enter a second number : ");
      CUserInput.ReadNumberFromConsole(ref numbers[1]);
      highestValue = numbers[0] > numbers[1] ? numbers[0] : numbers[1];
      Console.WriteLine("The maximum value of the two numbers entered is : {0}", highestValue);
    }
  }
}
