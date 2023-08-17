using Microsoft.AspNetCore.Mvc;

namespace HomeTaskMVC2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
