using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Monkey_Finances.Models;

namespace Monkey_Finances.Controllers
{
    public class RegisterController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}