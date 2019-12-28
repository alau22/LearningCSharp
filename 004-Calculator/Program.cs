using System;

namespace Calculator
{
  class Program
  {
    static int Main()
    {
      Console.WriteLine("Enter a number");
      double number1 = double.Parse(Console.ReadLine());
      Console.WriteLine("enter an operator");
      string @operator = Console.ReadLine();
      Console.WriteLine("Enter another number");
      double number2 = double.Parse(Console.ReadLine());

      double result;
      switch (@operator)
      {
        case "+":
          result = number1 + number2;
          break;
        case "-":
          result = number1 - number2;
          break;
        case "*":
          result = number1 * number2;
          break;
        case "/":
          if (number2 == 0)
          {
            Console.WriteLine("Error");
            return 2;
          }
          result = number1 / number2;
          break;
        default:
          Console.WriteLine("Error");
          return 1;
      }

      Console.WriteLine("Here's your calculation: {0} {1} {2} = {3}", number1, @operator, number2, result);

      return 0;
    }
  }
}
