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
      // Word newWord = new Word(response);
      // int result = newWord.Letter(response);
      // Console.WriteLine("The word " + response + " has a score of " + result);
      // Main();
    }
  }
}