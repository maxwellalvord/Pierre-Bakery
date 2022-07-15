using System;

namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("How many loaves of bread do you want?");
      string breadResponse = Console.ReadLine();
      int errorCatch = Convert.ToInt32(breadResponse);
      if (errorCatch > 12)
      {
        Console.WriteLine("Sorry we only sell our bread at a maximum of a dozen");
        Main();
      }
      Bread newBread = new Bread(errorCatch);
      int result = newBread.Number(errorCatch);
      Console.WriteLine("For " + breadResponse + " you pay a price of $" + result);
      Main();
    }
  }
}