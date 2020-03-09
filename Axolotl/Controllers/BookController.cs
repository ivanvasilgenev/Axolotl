using System;
using Microsoft.AspNetCore.Mvc;

namespace Axolotl.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}