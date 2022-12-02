using Microsoft.AspNetCore.Mvc;
using Monkey_Finances.Models;
using Monkey_Finances.Repositorio;

namespace Monkey_Finances.Controllers
{
    public class RegistroController : Controller
    {
        private readonly IRegistroRepositorio _registroRepositorio;

        public RegistroController(IRegistroRepositorio registroRepositorio)
        {
            _registroRepositorio = registroRepositorio;
        }

        public IActionResult Index()
        {
            List<RegistroModel> registro = _registroRepositorio.BuscarTodos();
            return View(registro);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            RegistroModel registro = _registroRepositorio.ListarPorId(id);
            return View(registro);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            RegistroModel registro = _registroRepositorio.ListarPorId(id);
            return View(registro);
        }
        
        public IActionResult Apagar(int id)
        {
            _registroRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Criar(RegistroModel registro)
        {
            _registroRepositorio.Adicionar(registro);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Alterar(RegistroModel registro)
        {
            _registroRepositorio.Atualizar(registro);

            return RedirectToAction("Index");
        }


    }
}
