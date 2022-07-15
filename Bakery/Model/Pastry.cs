using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public int Amount { get; set;}
    
    public int Number (int number)
    {
      number = number * 2;
      return number;
    }
    
    public Pastry(int amount)
    { 
      Amount = amount;
    }

  }
  
}