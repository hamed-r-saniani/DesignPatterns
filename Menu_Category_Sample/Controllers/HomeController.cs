using Menu_Category_Sample.Models;
using Menu_Category_Sample.Models.Contexts;
using Menu_Category_Sample.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Menu_Category_Sample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataBaseContext context;

        public HomeController(ILogger<HomeController> logger, DataBaseContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            var menus = context.CategoryComponents.ToList();
            string result = "";
            // Because Leaf are print into their composites we use Where to just print Composites
            //foreach (var item in menus.Where(p => p.GetType() == typeof(Category)))
            foreach (var item in menus.Where(p => p.GetType() == typeof(CategoryItem)))
            {
                context.Products.Add(new Product //if we use Category in foreach Give Error because oru item is Category
                {
                    Name = "test",
                    CategoryItem = item as CategoryItem,
                });
                context.SaveChanges();

                result += item.Print();
            }

            return View();
        }

        public IActionResult TempData() 
        {
            var Products = new Category("محصولات");
            var testItem = new CategoryItem("موبایل", "https://google.com/");
            Products.Add(testItem);
            Products.Add(new CategoryItem("لپ تاپ", "https://google.com/"));
            Products.Add(new CategoryItem("لوازم جانبی", "https://google.com/"));
            Products.Add(new CategoryItem("کتاب", "https://google.com/"));

            context.CategoryComponents.Add(Products);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
