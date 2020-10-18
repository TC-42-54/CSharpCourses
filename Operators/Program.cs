using System;

namespace Operators
{
  class Program
  {
    static void Main(string[] args)
    {
      byte a = 1;
      byte b = 2;
      byte c = 3;

      Console.WriteLine(!(c > b || c == a));
    }
  }
}
