using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebLabNew.Models;

namespace WebLabNew.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Text"] = "Лабораторная работа 2"; return View();
        }
        

    }
}
