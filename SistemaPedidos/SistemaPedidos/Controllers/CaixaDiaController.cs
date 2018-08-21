using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SistemaPedidos.Service.Controllers
{
    public class CaixaDiaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}