using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrders.Models;
using System.Collections.Generic;
using System;

namespace VendorOrders.Tests;

[TestClass]
public class VendorTests
{
  [TestMethod]
  public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
  {
    Vendor newVendor = new Vendor("I Buy Pastries");
    Assert.AreEqual(typeof(Vendor), newVendor.GetType());
  }

  [TestMethod]
  public void OnNewVendor_NewVendorNameShouldEqual_name()
  {
    string newName = "I Buy Pastries";
    string badName = "I Don't Buy Pastries";
    Vendor newVendor = new Vendor(newName);
    Assert.AreNotEqual(newVendor.Name, badName);
    Assert.AreEqual(newVendor.Name, newName);
  }
}