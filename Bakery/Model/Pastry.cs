using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public int Amount { get; set;}
    
    public int Number (int number)
    {
      return 10;
    }
    
    public Pastry(int amount)
    { 
      Amount = amount;
    }

  }
  
}