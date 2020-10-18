using System;

namespace TypeConversion
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        string str = "1234";
        bool b = Convert.ToBoolean(str);

        Console.WriteLine(b);
      }
      catch (Exception)
      {
        Console.WriteLine("The string could not be converted to a boolean");
      }
    }
  }
}
