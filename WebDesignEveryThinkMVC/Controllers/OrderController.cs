using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDesignEveryThinkMVC.Entity;
using WebDesignEveryThinkMVC.Models;

namespace WebDesignEveryThinkMVC.Controllers
{
    [Authorize(Roles = "admin")]
    public class OrderController : Controller
    {
        DataContext db = new DataContext();

        // GET: Order
        public ActionResult Index()
        {
            var orders = db.Orders.Select(i => new AdminOrderModel() 
            { 
                Id = i.Id,
                OrderNumber = i.OrderNumber,
                OrderDate = i.OrderDate,
                OrderState = i.OrderState,
                Total = i.Total,
                Count =i.Orderlines.Count

            }).OrderByDescending(i => i.OrderDate).ToList();

            return View(orders);
        }

        public ActionResult Details(int id) 
        {
            var entity = db.Orders
                .Where(i => i.Id == id)
                .Select(i => new OrderDetailsModel()
                {

                    OrderId = i.Id,
                    OrderNumber = i.OrderNumber,
                    Total = i.Total,
                    OrderDate = i.OrderDate,
                    OrderState = i.OrderState,
                    AddressTitle = i.AddressTitle,
                    AddressLine = i.AddressLine,
                    City = i.City,
                    Town = i.Town,
                    ZipCode = i.ZipCode,
                    Orderlines = i.Orderlines.Select(a => new OrderLineModel()
                    {
                        ProductId = a.ProductId,
                        ProductName = a.Product.ProductName,
                        Image = a.Product.ProductImage,
                        Quantity = a.Quantity,
                        Price = a.Price,

                    }).ToList()

                }).FirstOrDefault();

            return View(entity);
        }
    }
}