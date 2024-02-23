using Finexo.Core.Entities;
using Finexo.Service.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Finexo_MVC.Controllers
{
    public class HomeController : Controller
    {
        readonly IPositionService positionService;

        public HomeController(IPositionService positionService)
        {
            this.positionService = positionService;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Position> positions = await positionService.GetAllAsync();

            return View(positions);
        }
    }
}
