using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrders.Models;
using System.Collections.Generic;
using System;

namespace VendorOrders.Tests;

[TestClass]
public class VendorTests : IDisposable
{
  public void Dispose()
  {
    Vendor.ClearAll();
  }
  
  [TestMethod]
  public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
  {
    Vendor newVendor = new Vendor("I Buy Pastries");
    Assert.AreEqual(typeof(Vendor), newVendor.GetType());
  }

  [TestMethod]
  public void GetVendorName_ReturnsName_Name()
  {
    string newName = "I Buy Pastries";
    string badName = "I Don't Buy Pastries";
    Vendor newVendor = new Vendor(newName);
    Assert.AreNotEqual(newVendor.Name, badName);
    Assert.AreEqual(newVendor.Name, newName);
  }

  [TestMethod]
  public void GetAllVendors_ReturnsVendorList_List()
  {
    //arrange
    string name1 = "I Buy Pastries";
    string name2 = "I Buy Bread";
    string name3 = "I Buy Both";
    Vendor newVendor1 = new Vendor(name1);
    Vendor newVendor2 = new Vendor(name2);
    Vendor newVendor3 = new Vendor(name3);
    List<Vendor> expectedList = new List<Vendor> { newVendor1, newVendor2, newVendor3 };

    //Act
    List<Vendor> result = Vendor.GetAll();
    
    //Assert
    Assert.AreEqual(expectedList.Count, result.Count);

  }
}