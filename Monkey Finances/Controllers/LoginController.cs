using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Monkey_Finances.Models;

namespace Monkey_Finances.Controllers
{
    public class LoginController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (loginModel.Email == "asd@asd" && loginModel.Senha == "123")
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    TempData["MensagemErro"] = $"email ou senha inválidos";

                }

                return View("Index");
            }
            catch (System.Exception)
            {
                TempData["MensagemErro"] = $"erro ao logar";
                throw;
            }
        }
    }
}