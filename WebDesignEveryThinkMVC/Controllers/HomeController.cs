using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDesignEveryThinkMVC.Entity;
using WebDesignEveryThinkMVC.Models;

namespace WebDesignEveryThinkMVC.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();

        public ActionResult Index()
        {
            var urunler = _context.Products
                .Where(i => i.IsHome && i.IsApproved)
                .Select(i => new ProductModel()
                {
                    Id = i.Id,
                    ProductName = i.ProductName.Length > 15 ? i.ProductName.Substring(0, 10) + "..." : i.ProductName,
                    ProductDescription = i.ProductDescription.Length > 50?i.ProductDescription.Substring(0,47)+"...":i.ProductDescription,
                    ProductPrice = i.ProductPrice,
                    ProductImage = i.ProductImage,
                    CategoryId = i.CategoryId,
                }).ToList();

            return View(urunler);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Details(int id)
        {
            return View(_context.Products.Where(i => i.Id == id).FirstOrDefault());
        }

        

        public ActionResult List(int? id)
        {
            var urunler = _context.Products
                .Where(i => i.IsHome && i.IsApproved)
                .Select(i => new ProductModel()
                {
                    Id = i.Id,
                    ProductName = i.ProductName.Length > 15 ? i.ProductName.Substring(0, 10) + "..." : i.ProductName,
                    ProductDescription = i.ProductDescription.Length > 50 ? i.ProductDescription.Substring(0, 47) + "..." : i.ProductDescription,
                    ProductPrice = i.ProductPrice,
                    ProductImage = i.ProductImage,
                    CategoryId = i.CategoryId,
                }).AsQueryable();
            /*VeriTabanındaki sorguyu daha çalıtırmadık*/

            if (id != null)
            {
                urunler = urunler.Where(i => i.CategoryId == id);
            }

            return View(urunler.ToList());
        }

        public PartialViewResult GetCategories()
        {
            return PartialView(_context.Categories.ToList());
        }
        
    }
}