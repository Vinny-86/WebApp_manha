﻿using Microsoft.AspNetCore.Mvc;

namespace WebApp_manhã.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

    }
}
