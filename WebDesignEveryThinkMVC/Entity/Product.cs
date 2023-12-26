using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebDesignEveryThinkMVC.Entity
{
    public class Product
    {
        public int Id { get; set; }

        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        [DisplayName("Product Description")]
        public string ProductDescription { get; set; }
        public double ProductPrice { get; set; }

        [DisplayName("Product Image")]
        public string ProductImage { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}