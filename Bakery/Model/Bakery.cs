using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int Amount { get; set;}
    
    public int Number (int number)
    {
      return 10;
    }
    
    public Bread(int amount)
    { 
      Amount = amount;
    }

  }
  
}