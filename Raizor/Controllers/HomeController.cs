using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Razor.Models;

namespace Raizor.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            Product[] products =
            {
                new Product
                {
                    ProductionId = 1,
                    Name = "Kayak",
                    Description = "A boat for one person",
                    Category = "Watersport",
                    Price = 275m
                },
                new Product
                {
                    ProductionId = 2,
                    Name = "Katamaran",
                    Description = "A boat for many people",
                    Category = "Watersport",
                    Price = 500m
                }
            };

        ViewBag.StockLevel = 2;
            return View(products);
        }
    }
}