using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PastryModels;

namespace PastryTests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void ItemConstructor_CreatePastryObject_CustomerPastry()
    {
      PastryClass newCustomer = new PastryClass();
      newCustomer.GetPastryCount("1");
      Assert.AreEqual(typeof(PastryClass), newCustomer.GetType());
    }
    [TestMethod]
    public void ItemConstructor_CorrectlyParseString_int()
    {
      PastryClass newCustomer = new PastryClass();
      int pastryCount = newCustomer.GetPastryCount("1");
      Assert.AreEqual(1, pastryCount);
    }
    [TestMethod]
    public void AddPastry_AddPastryPrices_Int()
    {
      PastryClass newCustomer = new PastryClass();
      int pastryCount = newCustomer.GetPastryCount("1");
      int pastryTotal = newCustomer.PastryCalculator(pastryCount);
      Assert.AreEqual(2, pastryTotal);
    }
    [TestMethod]
    public void AddPastry_CorrectlyCalculateDealPrice_Int()
    {
      PastryClass newCustomer = new PastryClass();
      int pastryCount = newCustomer.GetPastryCount("3");
      int pastryTotal = newCustomer.PastryCalculator(pastryCount);
      pastryTotal = newCustomer.PastryDealCalculator(pastryTotal, pastryCount);
      Assert.AreEqual(5, pastryTotal);
    }
  }
} 
