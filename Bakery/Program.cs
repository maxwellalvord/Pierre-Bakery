using System;

namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("How many loaves of bread do you want? They cost 5 dollars and have a buy 2 get one free sale");
      string breadResponse = Console.ReadLine();
      int errorCatch = Convert.ToInt32(breadResponse);
      if (errorCatch > 12)
      {
        Console.WriteLine("Sorry we only sell our bread at a maximum of a dozen per customer");
        Main();
      }

      Console.WriteLine("How many pastries do you want? They cost 2 dollars but you get an additional dollar off every third pastry.");
      string pastryResponse = Console.ReadLine();
      int errorCatch2 = Convert.ToInt32(pastryResponse);
      if (errorCatch2 > 8)
      {
        Console.WriteLine("Sorry we only sell our pastries at a maximum of 8 per customer");
        Main();
      }

      Pastry newPastry = new Pastry(errorCatch2);
      int result2 = newPastry.Number(errorCatch2);
      Bread newBread = new Bread(errorCatch);
      int result = newBread.Number(errorCatch);
      Console.WriteLine("For " + breadResponse + " loaves of bread you pay a price of $" + result);
      Console.WriteLine("For " + pastryResponse + " pastries you pay a price of $" + result2);
      
      int finalTotal = result + result2;
      Console.WriteLine("All together your final total will be $" + finalTotal);
      Main();
    }
  }
}