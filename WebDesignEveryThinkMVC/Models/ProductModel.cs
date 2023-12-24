using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDesignEveryThinkMVC.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double ProductPrice { get; set; }
        public string ProductImage { get; set; }

        public int CategoryId { get; set; }
    }
}