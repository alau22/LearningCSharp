using System;

namespace HelloName
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("What's your name?");
      string name = Console.ReadLine();
      Console.WriteLine("Bonjour {0}!", name);
    }
  }
}
