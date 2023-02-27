using Microsoft.AspNetCore.Mvc;

namespace MVCCoreWebApp_bai13.Controllers
{
    public class CustomerController : Controller
    {
        [Route("khach-hang")]
        [Route("khach-hang/vip")]
        public string Vip()
        {
            return "khach hang vip";
        }

        //[Route("")]
        [Route("khach-hang/normal/{id?}")]
        public string Normal(int id)
        {
            return "khach hang normal ,id=" +id;
        }
    }
}
