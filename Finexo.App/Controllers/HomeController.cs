﻿using Microsoft.AspNetCore.Mvc;

namespace Finexo_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
