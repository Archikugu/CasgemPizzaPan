﻿using Microsoft.AspNetCore.Mvc;

namespace PizzaPan.UI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
