﻿using Microsoft.AspNetCore.Mvc;

namespace PizzaPan.UI.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}