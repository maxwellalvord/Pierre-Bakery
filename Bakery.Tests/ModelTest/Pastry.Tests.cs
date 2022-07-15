using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests 
  { 
    // public void Dispose()
    // {
    //   Word.ClearAll();
    // }
   
   [TestMethod]
    public void PastryAmountConstructor_CreatesInstanceOfAmountOfPastries_true()
    {
      int pastryInput = 1;
      Pastry newPastry = new Pastry(pastryInput);
      Assert.AreEqual(pastryInput, newPastry.Amount);
    }

    [TestMethod]
    public void Price_CalculatePriceOfOnePastry_true()
    {
      int pastryInput = 1;
      int pastryPrice = 2;
      Pastry newPastry = new Pastry(pastryInput);
      Assert.AreEqual(pastryPrice, newPastry.Number(1));
    }
     [TestMethod]
    public void Price_CalculatePriceOfThreePastry_true()
    {
      int pastryInput = 3;
      int pastryPrice = 5; 
      Pastry newPastry = new Pastry(pastryInput);
      Assert.AreEqual(pastryPrice, newPastry.Number(3));
    }
    // [TestMethod]
    // public void Price_CalculatePriceOfFourPastry_true()
    // {
    //   int pastryInput = 4;
    //   int pastryPrice = 15; 
    //   Pastry newPastry = new Pastry(pastryInput);

    //   Assert.AreEqual(pastryPrice, newPastry.Number(4));
    // }
    // public void Price_CalculatePriceOfSixPastry_true()
    // {
    //   int pastryInput = 6;
    //   int pastryPrice = 20; 
    //   Pastry newPastry = new Pastry(pastryInput);

    //   Assert.AreEqual(pastryPrice, newPastry.Number(6));
    // }
  }
}