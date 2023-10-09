using System.Collections.Generic;
using System;

namespace VendorOrders.Models
{
  public class Order
  {
    public string Title { get; set; }
    public int OrderId { get; }
    private static List<Order> _instances = new List<Order> { };
    public string Description { get; set; }
    public decimal Price { get; set; }
    public DateTime Date { get; set; }

    public Order( string title, string description, decimal price )
    {
      Title = title;
      _instances.Add(this);
      OrderId = _instances.Count;
      Description = description;
      Price = price;
      Date = DateTime.Today;
    } 
    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }

  }
}