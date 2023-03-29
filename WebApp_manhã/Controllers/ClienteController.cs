using Microsoft.AspNetCore.Mvc;

namespace WebApp_manhã.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Lista()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(string Nome, string Telefone)
        {
            if (string.IsNullOrEmpty(Nome)) {
                TempData["Erro"] = "O campo Nome não pode estar vazio";
            }

            if (string.IsNullOrEmpty(Telefone)) {
                TempData["Erro"] = "O campo Telefone não pode estar vazio";
            }

            return View();
        }

        public IActionResult Editar(int id)
        {
            return View();
        }

        public IActionResult Excluir(int id)
        {
            return View();
        }
    }
}
