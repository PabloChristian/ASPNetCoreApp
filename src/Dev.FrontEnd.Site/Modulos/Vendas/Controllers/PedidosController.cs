using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dev.FrontEnd.Site.Modulos.Vendas.Controllers
{
    [Area("Vendas")]
    //[Route("produtos")]
    public class PedidosController : Controller
    {
        //[Route("lista")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
