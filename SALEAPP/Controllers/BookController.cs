﻿using Microsoft.AspNetCore.Mvc;

namespace SALEAPP.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}