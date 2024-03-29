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
    public void Price_CalculatePriceOfThreeBread_true()
    {
      int breadInput = 3;
      int breadPrice = 10; 
      Bread newBread = new Bread(breadInput);

      Assert.AreEqual(breadPrice, newBread.Number(3));
    }
    [TestMethod]
    public void Price_CalculatePriceOfFourBread_true()
    {
      int breadInput = 4;
      int breadPrice = 15; 
      Bread newBread = new Bread(breadInput);

      Assert.AreEqual(breadPrice, newBread.Number(4));
    }
    [TestMethod]
    public void Price_CalculatePriceOfSixBread_true()
    {
      int breadInput = 6;
      int breadPrice = 20; 
      Bread newBread = new Bread(breadInput);

      Assert.AreEqual(breadPrice, newBread.Number(6));
    }
  }
}