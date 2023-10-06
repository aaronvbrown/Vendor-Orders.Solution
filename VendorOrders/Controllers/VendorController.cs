using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorOrders.Models;

namespace VendorOrders.Controllers
{
  public class VendorsController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName)
    {
      Vendor newVendor = new Vendor(vendorName);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      // List<Orders> vendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      // model.Add("items", vendorOrders);
      return View(model);
    }


    // This one creates new Items within a given Category, not new Categories:

    [HttpPost("/orders/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderDescription)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      // Order newOrder = new Order(orderDescription);
      // newOrder.Save();    // New code
      // foundVendor.AddOrder(newOrder);
      // List<Order> vendorOrders = foundVendor.Orders;
      // model.Add("orders", vendorOrders);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }

  }
}