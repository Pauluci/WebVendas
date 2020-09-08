using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebVendas.Controllers
{
    public class TesteController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Mensagem"] = "Esta é Página de teste";
            ViewData["nome"] = "Luan Honorio"; 
            ViewData["Email"] = "honorioluan@gmail.com";
            ViewData["numero"] = "2019073840";
            ViewData["meteria"] = "orientação a objeto";
            ViewData["dias"] = "Terça-Feira";
            ViewData["bim"] = "2 Bimestre";
            return View();
        }
    }
}
