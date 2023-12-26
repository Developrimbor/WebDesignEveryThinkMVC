using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebDesignEveryThinkMVC.Entity
{
    public class Category
    {
        public int Id { get; set; }

        [DisplayName("Category Name")]
        public string CategoryName { get; set; }

        public List<Product> Products { get; set; }
    }
}