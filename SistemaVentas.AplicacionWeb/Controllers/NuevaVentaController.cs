using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SistemaVentas.AplicacionWeb.Controllers
{
    public class NuevaVentaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}