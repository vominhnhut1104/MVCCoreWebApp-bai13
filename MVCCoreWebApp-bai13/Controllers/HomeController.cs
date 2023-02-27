using Microsoft.AspNetCore.Mvc;
using MVCCoreWebApp_bai13.Models;

namespace MVCCoreWebApp_bai13.Controllers
{
    public class HomeController : Controller
    {
       //[Route("Home/Index/{id:int}")] đây là cách dùng inline ( attribute based routing) 
        public IActionResult Index(int id)
        {
            var model = new IndexModel();
            model.Message = "hello from model, ID =" +id;
            return View(model);
        }
    }
}
