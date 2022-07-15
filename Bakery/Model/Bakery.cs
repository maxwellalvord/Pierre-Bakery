using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int Amount { get; set;}
    
    public int Number (int number)
    {
      if (number < 1)
      {
        number = 0;
      }
      else if(number % 12 == 0)
      {
        number = (number - 4) * 5;
      }
      else if(number % 9 == 0)
      {
        number = (number - 3) * 5;
      }
      else if(number % 6 == 0)
      {
        number = (number - 2) *5;
      }
      else if (number % 3 == 0)
      {
        number = (number - 1) * 5;
      }
      else
      {
        return Remainder(number);
      }
      return number;
    }

      public int Remainder(int number)
    { 
      if (number < 3)
        {
          number = number * 5;
        }
        else if(3 <= number & number < 6)
        {
          number = (number - 1) * 5;
        }
        else if (6 <= number & number < 9)
        {
          number = (number - 2) * 5;
        }
        else if(9 <= number & number > 12)
        {
          number = (number - 3) * 5;
        }
        else
        {
          number = (number - 3) * 5;
        }
      return number;
    }
    
    public Bread(int amount)
    { 
      Amount = amount;
    }

  }
  
}