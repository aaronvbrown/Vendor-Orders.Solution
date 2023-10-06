using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrders.Models;
using System.Collections.Generic;
using System;

namespace VendorOrders.Tests;

[TestClass]
public class OrderTests : IDisposable
{
  public void Dispose()
  {
    Order.ClearAll();
  }
  
  [TestMethod]
  public void OrderConstructor_CreatesInstanceOfOrder_Order()
  {
    string title1 = "1";
    string desc1 = "The first order";
    decimal price1 = 4.25m;
    
    Order newOrder = new Order(title1, desc1, price1);
    Assert.AreEqual(typeof(Order), newOrder.GetType());
  }

  [TestMethod]
  public void GetOrderTitle_ReturnsOrder_Order()
  {
    string title1 = "1";
    string desc1 = "The first order";
    decimal price1 = 4.25m;
    Order newOrder = new Order(title1, desc1, price1);
    Assert.AreEqual(newOrder.Title, title1);
  }

  // [TestMethod]
  // public void GetAll_ReturnsOrderList_List()
  // {
  //   //arrange
  //   string name1 = "1";
  //   string desc1 = "The first order"
  //   decimal price1 = 4.25m;
  //   string name3 = "I Buy Both";
  //   Order newOrder1 = new Order(name1);
  //   Order newOrder2 = new Order(name2);
  //   Order newOrder3 = new Order(name3);
  //   List<Order> expectedList = new List<Order> { newOrder1, newOrder2, newOrder3 };

  //   //Act
  //   List<Order> result = Order.GetAll();
    
  //   //Assert
  //   Assert.AreEqual(expectedList.Count, result.Count);

  // }
}