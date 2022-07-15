using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public int Amount { get; set;}
    
    public int Number (int number)
    {
      if(number > 5)
      {
        number = (number * 2) - 2;
      }
      else if(number > 2)
      {
        number = (number * 2) - 1;
      }
      else
      {
      number = number * 2;
      }
      return number;
    }
    
    public Pastry(int amount)
    { 
      Amount = amount;
    }

  }
  
}