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

  [TestMethod]
  public void GetAll_ReturnsOrderList_List()
  {
    //arrange
    string title1 = "Order the 1st";
    string desc1 = "The first order";
    decimal price1 = 4.25m;
    string title2 = "Order the 2nd";
    string desc2 = "The second order";
    decimal price2 = 13.11m;
    Order newOrder1 = new Order(title1, desc1, price1);
    Order newOrder2 = new Order(title2, desc2, price2);
    List<Order> expectedList = new List<Order> { newOrder1, newOrder2 };

    //Act
    List<Order> result = Order.GetAll();
    
    //Assert
    Assert.AreEqual(typeof(List<Order>), result.GetType());
  }

  [TestMethod]
  public void FindOrder_ReturnsOrder_Order()
  {
    //arrange
    string title1 = "Order the 1st";
    string desc1 = "The first order";
    decimal price1 = 4.25m;
    string title2 = "Order the 2nd";
    string desc2 = "The second order";
    decimal price2 = 13.11m;
    Order newOrder1 = new Order(title1, desc1, price1);
    Order newOrder2 = new Order(title2, desc2, price2);

    //Act
    Order result = Order.Find(2);
    
    //Assert
    Assert.AreEqual(result, newOrder2);
  }
}