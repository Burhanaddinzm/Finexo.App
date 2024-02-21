using Microsoft.AspNetCore.Mvc;

namespace Finexo.App.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
