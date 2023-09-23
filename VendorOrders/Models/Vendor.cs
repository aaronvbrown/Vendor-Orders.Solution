using System.Collections.Generic;
using System;

namespace VendorOrders.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }

    public string Description { get; set; }

    public Vendor(string vendorName, string vendorDescription = "")
    {
      Name = vendorName;
      Description = vendorDescription;
      _instances.Add(this);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

  }
}

