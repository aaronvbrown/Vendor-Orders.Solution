using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorOrders.Models;

namespace VendorOrders.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/vendors/{id}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Order order = Order.Find(vendorId);
      return View(order);
    }

    [HttpGet("vendors/{vendorId}/orders/{orderId}/")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }

  }
}