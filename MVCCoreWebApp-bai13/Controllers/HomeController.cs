using Microsoft.AspNetCore.Mvc;
using MVCCoreWebApp_bai13.Models;

namespace MVCCoreWebApp_bai13.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new IndexModel();
            model.Message = "hello from model";
            return View(model);
        }
    }
}
