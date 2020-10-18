using System;

namespace Types
{
  public enum CustomerType
  {
    Bronze,
    Silver,
    Gold
  }
  public class Person
  {
    public int Age;
  }
  class Program
  {
    static void Main(string[] args)
    {
      int a = 10;
      int b = a;

      b++;

      Console.WriteLine(string.Format("a : {0} b : {1}", a, b));

      int[] array1 = new int[3] { 1, 2, 3 };
      int[] array2 = array1;

      array2[0] = 0;

      Console.WriteLine(string.Join(',', array1));
      Console.WriteLine(string.Join(',', array2));
      int number = 1;
      Increment(number);
      Console.WriteLine(number);
      Person person = new Person() { Age = 20 };
      MakeOld(person);
      Console.WriteLine(person.Age);
      Console.WriteLine((int)CustomerType.Bronze);
    }
    public static void Increment(int number)
    {
      number += 10;
    }
    public static void MakeOld(Person person)
    {
      person.Age += 10;
    }
  }
}
