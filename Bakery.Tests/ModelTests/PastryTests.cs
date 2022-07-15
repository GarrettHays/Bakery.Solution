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
      newCustomer.Pastry("1");
      Assert.AreEqual(typeof(PastryClass), newCustomer.GetType());
    }
    [TestMethod]
    public void ItemConstructor_CorrectlyParseString_int()
    {
      PastryClass newCustomer = new PastryClass();
      newCustomer.Pastry("1");
      Assert.AreEqual(1, newCustomer.PastryCount);
    }
    [TestMethod]
    public void AddPastry_AddPastryPrices_Int()
    {
      PastryClass newCustomer = new PastryClass();
      newCustomer.Pastry("1");
      newCustomer.PastryCalculator();
      Assert.AreEqual(2, newCustomer.PastrySubTotal);
    }
    [TestMethod]
    public void AddPastry_CorrectlyCalculateDealPrice_Int()
    {
      PastryClass newCustomer = new PastryClass();
      newCustomer.Pastry("3");
      newCustomer.PastryCalculator();
      newCustomer.PastryDealCalculator();
      Assert.AreEqual(5, newCustomer.PastrySubTotal);
    }
  }
} 
//     [TestMethod]
// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
// {
//   // any necessary logic to prep for test; instantiating new classes, etc.
//   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
  //}
    // [TestMethod]
    // public void ItemConstructor_CreatesInstanceOfItem_Item()
    // {
    //   Item newItem = new Item();
    //   Assert.AreEqual(typeof(Item), newItem.GetType());
    // }

//     [TestMethod]
//     public void GetDescription_ReturnsDescription_String()
//     {
//       string description = "Walk the dog.";
//       Item newItem = new Item(description);
//       string result = newItem.Description;
//       Assert.AreEqual(description, result);
//     }

//     [TestMethod]
// public void GetDescription_ReturnsDescription_String()
// {
//   //Arrange
//   string description = "Walk the dog.";
//   Item newItem = new Item(description);

//   //Act
//   string result = newItem.Description;

//   //Assert
//   Assert.AreEqual(description, result);
// }
