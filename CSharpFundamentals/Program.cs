//using CSharpFundamentals.Math;
using System;

namespace CSharpFundamentals
{
  public enum ShippingMethod
  {
    RegularAirMail = 1,
    RegisteredAirMail = 2,
    Express = 3
  }
  class Program
  {
    static void Main(string[] args)
    {
      /*Person thomas = new Person();
      thomas.FirstName = "Thomas";
      thomas.LastName = "Chezieres";
      thomas.Introduce();
      Calculator calculator = new Calculator();

      int result = calculator.Add(1, 2);

      Console.WriteLine("The result to the calculator Add method is : {0}", result);*/
      /*int[] numbers = new int[3];

      numbers[0] = 1;
      numbers[1] = 2;
      numbers[2] = 3;

      Console.WriteLine(numbers[0]);
      Console.WriteLine(numbers[1]);
      Console.WriteLine(numbers[2]);

      bool[] flags = new bool[3];
      
      flags[0] = true;
      
      Console.WriteLine(flags[0]);
      Console.WriteLine(flags[1]);
      Console.WriteLine(flags[2]);

      string[] names = new string[3] { "Thomas", "Carolina", "Charlotte" };
      
      Console.WriteLine(names[0]);
      Console.WriteLine(names[1]);
      Console.WriteLine(names[2]);*/
      /*string firstName = "Thomas";
      string lastName = "Chezieres";

      string fullName = string.Format("{0} {1}", firstName, lastName);

      Console.WriteLine(fullName);

      string[] names = new string[3] { "John", "Jack", "Mary" };

      string formattedNames = string.Join(',', names);

      Console.WriteLine(formattedNames);

      string text = @"Hi Thomas
Look into the following paths
c:\test\test\test";
      
      Console.WriteLine(text);*/
      int method = (int)ShippingMethod.Express;
      ShippingMethod methodId = ShippingMethod.Express;
      //Console.WriteLine(method);
      //Console.WriteLine((ShippingMethod)method);
      //Console.WriteLine(methodId.ToString());
      string methodName = "Express";
      ShippingMethod shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
      Console.WriteLine(shippingMethod);
    }
  }
}
