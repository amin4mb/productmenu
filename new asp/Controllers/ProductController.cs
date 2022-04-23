using Microsoft.AspNetCore.Mvc;
using new_asp.Models;
using System.Diagnostics;
namespace new_asp.Controllers

{
    public class ProductController : Controller
    {
        public IActionResult product()
        {
            var products = ProductDB.GetProducts();
            return View(products);
        }
        public IActionResult Details(Guid id) {

            var product = ProductDB.Get(id);
            return View(product);
        }
        
        public IActionResult Edit(Guid id)
        {   
            var p = ProductDB.Get(id);
            return View(p);
        }
        [HttpPost]
        public IActionResult Edit(product pp )
        {
            int dd = ProductDB.products.FindIndex(p => p.Id == pp.Id);
            ProductDB.products[dd] = pp;
            return RedirectToAction("product");
        }
        public IActionResult Delete(Guid id)
        {
            var result = ProductDB.Delete(id);
            if (result)
                return RedirectToAction("product");
            return View();
        }

        

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(product p)
        {
            
            p.Id = Guid.NewGuid() ;
            ProductDB.Add(p);
            return RedirectToAction("product");
        }


    }
}