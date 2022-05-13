using Microsoft.AspNetCore.Mvc;

namespace MeetDoctor.Controllers
{    
     [Route("[controller]")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("~/")]
        [Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("[action]")]
        public IActionResult About()
        {
            return View();
        }

        [Route("[action]")]
        public IActionResult Details()
        {
            return View();
        }


    }
}
