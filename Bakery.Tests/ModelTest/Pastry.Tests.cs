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
    public void BreadAmountConstructor_CreatesInstanceOfAmountOfBread_true()
    {
      int pastryInput = 1;
      Pastry newPastry = new Pastry(pastryInput);
      Assert.AreEqual(pastryInput, newPastry.Amount);
    }

    // [TestMethod]
    // public void Price_CalculatePriceOfOneBread_true()
    // {
    //   int breadInput = 1;
    //   int breadPrice = 5; 
    //   Pastry newBread = new Pastry(breadInput);

    //   Assert.AreEqual(breadPrice, newBread.Number(1));
    // }
    //  [TestMethod]
    // public void Price_CalculatePriceOfthreeBread_true()
    // {
    //   int breadInput = 3;
    //   int breadPrice = 10; 
    //   Pastry newBread = new Pastry(breadInput);

    //   Assert.AreEqual(breadPrice, newBread.Number(3));
    // }
    // [TestMethod]
    // public void Price_CalculatePriceOfFourBread_true()
    // {
    //   int breadInput = 4;
    //   int breadPrice = 15; 
    //   Pastry newBread = new Pastry(breadInput);

    //   Assert.AreEqual(breadPrice, newBread.Number(4));
    // }
    // public void Price_CalculatePriceOfSixBread_true()
    // {
    //   int breadInput = 6;
    //   int breadPrice = 20; 
    //   Pastry newBread = new Pastry(breadInput);

    //   Assert.AreEqual(breadPrice, newBread.Number(6));
    // }
  }
}