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
      newCustomer.Bread("1");
      Assert.AreEqual(typeof(BreadClass), newCustomer.GetType());
    }
    [TestMethod]
    public void ItemConstructor_CorrectlyParseString_int()
    {
      BreadClass newCustomer = new BreadClass();
      newCustomer.Bread("1");
      Assert.AreEqual(1, newCustomer.BreadCount);
    }
    [TestMethod]
    public void AddBread_AddBreadPrices_Int()
    {
      BreadClass newCustomer = new BreadClass();
      newCustomer.Bread("1");
      newCustomer.BreadCalculator();
      Assert.AreEqual(5, newCustomer.BreadSubTotal);
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