using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BakeryTests 
  { 
    // public void Dispose()
    // {
    //   Word.ClearAll();
    // }
   
   [TestMethod]
    public void BreadAmountConstructor_CreatesInstanceOfAmountOfBread_true()
    {
      int breadInput = 1;
      Bread newBread = new Bread(breadInput);
      Assert.AreEqual(breadInput, newBread.Amount);
    }

    [TestMethod]
    public void Price_CalculatePriceOfOneBread_true()
    {
      int breadInput = 1;
      int breadPrice = 5; 
      Bread newBread = new Bread(breadInput);

      Assert.AreEqual(breadPrice, newBread.Number(1));
    }
     [TestMethod]
    public void Price_CalculatePriceOfthreeBread_true()
    {
      int breadInput = 3;
      int breadPrice = 10; 
      Bread newBread = new Bread(breadInput);

      Assert.AreEqual(breadPrice, newBread.Number(3));
    }
  }
}