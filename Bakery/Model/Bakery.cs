using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int Amount { get; set;}
    
    public int Number (int number)
    {
      if (number % 3 == 0)
      {
        number = (number - 1) * 5;
      }
      else
      {
        number = number * 5;
      }
      return number;
    }
    
    public Bread(int amount)
    { 
      Amount = amount;
    }

  }
  
}