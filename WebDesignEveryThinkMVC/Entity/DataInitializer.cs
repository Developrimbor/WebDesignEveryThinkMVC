using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebDesignEveryThinkMVC.Identity;

namespace WebDesignEveryThinkMVC.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category() {CategoryName = "Graphic Design" },
                new Category() {CategoryName = "Logo" },
                new Category() {CategoryName = "3D" },
                new Category() {CategoryName = "Pixel Art" },
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }

            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product() 
                { 
                    ProductName = "Ball 3D Model", 
                    ProductDescription = "Blender ile oluşturulmuştur. Oyunlarınızda, animasyonlarınızda ve projelerinizde kullancabileceğiniz bir modeldir.", 
                    ProductPrice = 5, 
                    ProductImage = "Ball.png", 
                    IsApproved=true, 
                    CategoryId = 1, 
                    IsHome = true 
                },
                
                new Product() 
                { 
                    ProductName = "Cafe Polygon 3D Model", 
                    ProductDescription = "Made with Adobe Photoshop", 
                    ProductPrice = 5, 
                    ProductImage = "cafe.png", 
                    IsApproved=true, 
                    CategoryId = 1, 
                    IsHome = true 
                },
               
                new Product() 
                { 
                    ProductName = "ÇevikYazılımGeliştirme", 
                    ProductDescription = "Made with Adobe Photoshop", 
                    ProductPrice = 5, 
                    ProductImage = "Guitar.jpg", 
                    IsApproved=true, 
                    CategoryId = 1, 
                    IsHome = true  
                },
                
                new Product() 
                { 
                    ProductName = "ÇevikYazılımGeliştirme", 
                    ProductDescription = "Made with Adobe Photoshop", 
                    ProductPrice = 5, 
                    ProductImage = "Ball.png", 
                    IsApproved=true, 
                    CategoryId = 1, 
                },
                
                new Product() 
                { 
                    ProductName = "ÇevikYazılımGeliştirme", 
                    ProductDescription = "Made with Adobe Photoshop", 
                    ProductPrice = 5, 
                    ProductImage = "Ball.png", 
                    IsApproved=true, 
                    CategoryId = 2, 
                    IsHome = true  
                },

                new Product() 
                { 
                    ProductName = "ÇevikYazılımGeliştirme", 
                    ProductDescription = "Made with Adobe Photoshop", 
                    ProductPrice = 5, 
                    ProductImage = "Ball.png", 
                    IsApproved=true, 
                    CategoryId = 2, 
                    IsHome = true  
                },

                new Product() 
                { 
                    ProductName = "ÇevikYazılımGeliştirme", 
                    ProductDescription = "Made with Adobe Photoshop", 
                    ProductPrice = 5, 
                    ProductImage = "Ball.png", 
                    IsApproved=true, 
                    CategoryId = 2, 
                    IsHome = true  
                },
                
                new Product() 
                { 
                    ProductName = "ÇevikYazılımGeliştirme", 
                    ProductDescription = "Made with Adobe Photoshop", 
                    ProductPrice = 5, 
                    ProductImage = "Ball.png", 
                    IsApproved=true, 
                    CategoryId = 2, 
                    IsHome = true  
                },

            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }

            context.SaveChanges();



            if (!context.Roles.Any(i => i.Name == "admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole() { Name = "admin", Desscription = "admin rolü" };
                manager.Create(role);

            }

            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole() { Name = "user", Desscription = "user rolü" }; ;
                manager.Create(role);

            }

            if (!context.Users.Any(i => i.Name == "marvelous"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser()
                {
                    Name = "yusuf",
                    Surname = "gülmez",
                    UserName = "marvelous",
                    Email = "bymrglmz@gmail.com"
                };

                manager.Create(user, "1234567");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");
            }

            if (!context.Users.Any(i => i.Name == "wiodex"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser()
                {
                    Name = "fahri",
                    Surname = "coşkun",
                    UserName = "wiodex",
                    Email = "fahricoskun54@gmail.com"
                };

                manager.Create(user, "1234567");
                manager.AddToRole(user.Id, "user");
            }


            base.Seed(context);
        }
    }
}