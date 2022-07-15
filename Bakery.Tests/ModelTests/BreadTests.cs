using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using BreadModels;

namespace BreadTests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void ItemConstructor_CreateBreadObject_CustomerBread()
    {
      BreadClass newCustomer = new BreadClass();
      newCustomer.GetBreadCount("1");
      Assert.AreEqual(typeof(BreadClass), newCustomer.GetType());
    }
    [TestMethod]
    public void ItemConstructor_CorrectlyParseString_int()
    {
      BreadClass newCustomer = new BreadClass();
      int breadCount = newCustomer.GetBreadCount("1");
      Assert.AreEqual(1, breadCount);
    }
    [TestMethod]
    public void AddBread_AddBreadPrices_Int()
    {
      BreadClass newCustomer = new BreadClass();
      int breadCount = newCustomer.GetBreadCount("1");
      int breadTotal = newCustomer.BreadCalculator(breadCount);
      Assert.AreEqual(5, breadTotal);
    }
    [TestMethod]
    public void AddBread_CorrectlyCalculateDealPrice_Int()
    {
      BreadClass newCustomer = new BreadClass();
      int breadCount = newCustomer.GetBreadCount("3");
      int breadTotal = newCustomer.BreadCalculator(breadCount);
      breadTotal = newCustomer.BreadDealCalculator(breadTotal, breadCount);
      Assert.AreEqual(10, breadTotal);
    }
  }
} 