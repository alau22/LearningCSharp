using System;

namespace GuessTheNumber
{
  class Program
  {
    const int MaximumTry = 7;

    static int Main()
    {
      var random = new Random();
      int number = random.Next(1, 101);

      int x = 1;
      while (x <= MaximumTry)
      {
        Console.WriteLine("Choisissez un nombre de 1 à 100");
        int guess = int.Parse(Console.ReadLine());
        if (guess < number)
        {
          Console.WriteLine("Trop petit");
        }
        else if (guess > number)
        {
          Console.WriteLine("Trop grand");
        }
        else
        {
          Console.WriteLine("Bravo!");
          return 0;
        }
        x++;
      }
      Console.WriteLine("Perdant :'(");
      return 1;
    }
  }

}
