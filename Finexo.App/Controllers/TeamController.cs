using Microsoft.AspNetCore.Mvc;

namespace Finexo.App.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
