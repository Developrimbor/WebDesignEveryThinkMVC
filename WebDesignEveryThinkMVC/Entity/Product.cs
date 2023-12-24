using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDesignEveryThinkMVC.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double ProductPrice { get; set; }
        public string ProductImage { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}