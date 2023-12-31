﻿using Microsoft.AspNetCore.Mvc;
using PizzaPan.Business.Abstract;
using PizzaPan.Entities.Concrete;
using System;

namespace PizzaPan.UI.Controllers
{
    public class DiscountController : Controller
    {
        private readonly IDiscountService _discountService;

        public DiscountController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        [HttpGet]
        public IActionResult CreateCode()
        {
            string[] symbols = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
                    "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            int c1, c2, c3, c4;
            Random rnd = new Random();
            c1 = rnd.Next(0, symbols.Length);
            c2 = rnd.Next(0, symbols.Length);
            c3 = rnd.Next(0, symbols.Length);
            c4 = rnd.Next(0, symbols.Length);
            int c5 = rnd.Next(10, 100);
            ViewBag.v = symbols[c1] + symbols[c2] + symbols[c3] + symbols[c4] + c5;
            return View();
        }
        [HttpPost]
        public IActionResult CreateCode(Discount discount)
        {
            discount.CreatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            discount.EndingDate = Convert.ToDateTime(DateTime.Now.AddDays(3));
            _discountService.TInsert(discount);
            return RedirectToAction("CreateCode");
        }
        public IActionResult DiscountCodeList()
        {
            var values = _discountService.TGetList();
            return View(values);
        }
    }
}
