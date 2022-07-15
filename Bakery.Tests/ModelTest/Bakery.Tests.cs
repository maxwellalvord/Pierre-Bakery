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
    public void BreadAmountConstructor_CreatesInstanceOfAmountofBread_true()
    {
      int breadInput = 1;
      Bread newBread = new Bread(breadInput);
      Assert.AreEqual(breadInput, newBread.Amount);
    }

    // [TestMethod]
    // public void WordToLetter_ScoreLetters_true()
    // {
    //   string wordInput = "car";
    //   int wordScore = 5; 
    //   Bread newWord = new Bread(wordInput);

    //   Assert.AreEqual(wordScore, newWord.Letter("car"));
    // }
  }
}