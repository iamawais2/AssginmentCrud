using AssginmentCrud.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssginmentCrud.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var product = new ProductViewModel();
            using (var context = new AssignmentCrudEntities1())
            {
                product.Products = context.Products.ToList();
            }
            return View(product);
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var product = new ProductViewModel();
            using (var context = new AssignmentCrudEntities1())
            {
                product.Product = context.Products.FirstOrDefault(x => x.Id == Id);
            }
            return View(product);
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
        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            using (var context = new AssignmentCrudEntities1())
            {
                context.Products.AddOrUpdate(product);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Delete(int productId = 0)
        {
            using (var context = new AssignmentCrudEntities1())
            {
                var prod = context.Products.FirstOrDefault(x => x.Id == productId);
                context.Products.Remove(prod);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Add(int Id = 0)
        {
            if (Id == 0)
            {
                ViewData["IsUpdate"] = "false";
                return View();
            }
            Product product = new Product();
            using (var context = new AssignmentCrudEntities1())
            {
                product = context.Products.FirstOrDefault(x => x.Id == Id);
            }
            ViewData["IsUpdate"] = "true";
            return View(product);
        }
    }
}