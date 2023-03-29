using Microsoft.AspNetCore.Mvc;

namespace WebApp_manhã.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Lista()
        {
            return View();
        }
    }
}
