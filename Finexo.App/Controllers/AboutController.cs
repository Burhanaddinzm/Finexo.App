using Microsoft.AspNetCore.Mvc;

namespace Finexo_MVC.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
