using System;

namespace Age
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("What's your age?");
      int age = int.Parse(Console.ReadLine());
      if (age > 18)
      {
        Console.WriteLine("pay your bills");
      }
      else if (age == 18)
      {
        Console.WriteLine("congratulation!");
      }
      else
      {
        Console.WriteLine("go cry to your mom");
      }
    }

  }
}
