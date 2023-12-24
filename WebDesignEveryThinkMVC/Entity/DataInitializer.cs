using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebDesignEveryThinkMVC.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category() {CategoryName = "Graphic Design" },
                new Category() {CategoryName = "Logo" },
                new Category() {CategoryName = "3D" },
                new Category() {CategoryName = "Pixel Art" },
                new Category() {CategoryName = "Animation" }
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }

            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product() { ProductName = "ÇevikYazılımGeliştirme", ProductDescription = "Made with Adobe Photoshop", ProductPrice = 5, ProductImage = "a", IsApproved=true, CategoryId = 1, IsHome = true },
                new Product() { ProductName = "ÇevikYazılımGeliştirme", ProductDescription = "Made with Adobe Photoshop", ProductPrice = 5, ProductImage = "a", IsApproved=true, CategoryId = 1, IsHome = true },
                new Product() { ProductName = "ÇevikYazılımGeliştirme", ProductDescription = "Made with Adobe Photoshop", ProductPrice = 5, ProductImage = "a", IsApproved=true, CategoryId = 1, IsHome = true  },
                new Product() { ProductName = "ÇevikYazılımGeliştirme", ProductDescription = "Made with Adobe Photoshop", ProductPrice = 5, ProductImage = "a", IsApproved=true, CategoryId = 1, },
                
                new Product() { ProductName = "ÇevikYazılımGeliştirme", ProductDescription = "Made with Adobe Photoshop", ProductPrice = 5, ProductImage = "a", IsApproved=true, CategoryId = 2, IsHome = true  },
                new Product() { ProductName = "ÇevikYazılımGeliştirme", ProductDescription = "Made with Adobe Photoshop", ProductPrice = 5, ProductImage = "a", IsApproved=true, CategoryId = 2, IsHome = true  },
                new Product() { ProductName = "ÇevikYazılımGeliştirme", ProductDescription = "Made with Adobe Photoshop", ProductPrice = 5, ProductImage = "a", IsApproved=true, CategoryId = 2, IsHome = true  },
                new Product() { ProductName = "ÇevikYazılımGeliştirme", ProductDescription = "Made with Adobe Photoshop", ProductPrice = 5, ProductImage = "a", IsApproved=true, CategoryId = 2, IsHome = true  },

            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}