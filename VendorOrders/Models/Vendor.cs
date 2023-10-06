using System.Collections.Generic;
using System;

namespace VendorOrders.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public int Id { get; }
    public string Name { get; set; }
    public string Description { get; set; }

    // public List<Order> Orders { get; set; }

    public Vendor(string vendorName)
    {
      Name = vendorName;
      _instances.Add(this);
      Id = _instances.Count;
      // Orders = new List<Order>{};
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor Find(int searchID)
    {
      return _instances[searchID-1];
    }

    // public void AddOrder(Order order)
    // {
    //   Orders.Add(order);
    // }

  }
}

