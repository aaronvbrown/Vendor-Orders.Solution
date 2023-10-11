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
    Vendor newVendor = new Vendor("Pastry Buyer", "I Buy Pastries");
    Assert.AreEqual(typeof(Vendor), newVendor.GetType());
  }

  [TestMethod]
  public void GetVendorName_ReturnsName_Name()
  {
    string newName = "I Buy Pastries";
    string newDesc = "Pastry Buyer";
    string badName = "I Don't Buy Pastries";
    string badDesc = "Bad Pastry Buyer";
    Vendor newVendor = new Vendor(newName, newDesc);
    Assert.AreNotEqual(newVendor.Name, badName);
    Assert.AreEqual(newVendor.Name, newName);
  }

  [TestMethod]
  public void GetAllVendors_ReturnsVendorList_List()
  {
    //arrange
    string name1 = "Pastry Buyer";
    string name2 = "Bread Buyer";
    string name3 = "Both Buyer";
    string desc1 = "I Buy Pastries";
    string desc2 = "I Buy Bread";
    string desc3 = "I Buy Both";
    Vendor newVendor1 = new Vendor(name1, desc1);
    Vendor newVendor2 = new Vendor(name2, desc2);
    Vendor newVendor3 = new Vendor(name3, desc3);
    List<Vendor> expectedList = new List<Vendor> { newVendor1, newVendor2, newVendor3 };

    //Act
    List<Vendor> result = Vendor.GetAll();
    
    //Assert
    Assert.AreEqual(expectedList.Count, result.Count);
  }

  [TestMethod]
  public void AddOrder_ReturnsOrder_Order()
  {
    //arrange
    string name1 = "Pastry Buyer";
    string name2 = "Bread Buyer";
    string name3 = "Both Buyer";
    string desc1 = "I Buy Pastries";
    string desc2 = "I Buy Bread";
    string desc3 = "I Buy Both";
    Vendor newVendor1 = new Vendor(name1, desc1);
    Vendor newVendor2 = new Vendor(name2, desc2);
    Vendor newVendor3 = new Vendor(name3, desc3);
    List<Vendor> expectedList = new List<Vendor> { newVendor1, newVendor2, newVendor3 };

    //Act
    Vendor result = Vendor.Find(2);
    
    //Assert
    Assert.AreEqual(result, newVendor2);

  }
}