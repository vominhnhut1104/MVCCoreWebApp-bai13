using Microsoft.AspNetCore.Mvc;
using MVCCoreWebApp_bai13.Models;

namespace MVCCoreWebApp_bai13.Controllers
{
    public class ProductController : Controller
    {
        // [ActionName("modify")]
        // [Route("Product/modify")]
        //[NonAction]


        public List<ProductModel> products = new List<ProductModel>()
        { 
            new ProductModel() {Id= 1, Name ="Produc1", Available =true, Price=10000, PromotionPrice = 8000 },
            new ProductModel() {Id= 2, Name ="Produc2", Available =false, Price=20000, PromotionPrice = 18000 },

        };
        
        public IActionResult Index()
        {
            return View(products);  
        }
        //[HttpGet]
        //public string Edit(string id)
        //{
        //    return "hello from product";
        //}

        //[HttpPost]
        //public IActionResult Edit()
        //{
        //    return RedirectToAction("Index",controllerName: "Product");
        //}
    }
}
