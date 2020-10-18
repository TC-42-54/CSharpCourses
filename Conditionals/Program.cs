using System;

namespace Conditionals
{
  class Program
  {
    static void Main(string[] args)
    {
      Season season = Season.Summer;

      switch (season)
      {
        case Season.Autumn:
        case Season.Summer:
          Console.WriteLine("It's promotion time !");
          break;
        case Season.Spring:
          Console.WriteLine("It's Spring");
          break;
        default:
          Console.WriteLine("It's Winter");
          break;
      }
    }
  }
}
