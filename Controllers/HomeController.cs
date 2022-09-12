using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ATV03_JhonesYure.Models;

namespace ATV03_JhonesYure.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Agendamento()
        {
            return View();
        }
        public IActionResult Servicos()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Agendamento(Listagem p)
        {
            Dados.FormuAtual.AddLista(p);
            return View("Concluido");
        }
        
        public IActionResult Listamento()
        {
            List<Listagem> list = Dados.FormuAtual.liste();
            return View(list);
            
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
