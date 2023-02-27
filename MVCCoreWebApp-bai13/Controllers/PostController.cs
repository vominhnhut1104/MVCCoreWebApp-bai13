using Microsoft.AspNetCore.Mvc;

namespace MVCCoreWebApp_bai13.Controllers
{
    public class PostController : Controller
    {
        public IActionResult PostsByID(int id)
        {
            return View();
        }

        public IActionResult PostsByPostName(string id)
        {
            return View();
        }
    }
}
