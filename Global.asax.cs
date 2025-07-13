using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using BasicECommerceApp.Models;

namespace BasicECommerceApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // Seed data
            using (var context = new ECommerceDBContext())
            {
                if (!context.Products.Any())
                {
                    context.Products.Add(new Product { Name = "Laptop", Price = 50000 });
                    context.Products.Add(new Product { Name = "Smartphone", Price = 15000 });
                    context.Products.Add(new Product { Name = "Headphones", Price = 2000 });
                    context.SaveChanges();
                }
            }
        }
    }
}
