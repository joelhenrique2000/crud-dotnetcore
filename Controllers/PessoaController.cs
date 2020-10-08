using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using pessoa_exemplo.Models;
using pessoa_exemplo.Business;

namespace pessoa_exemplo.Controllers {
    public class PessoaController : Controller
    {
        private readonly ILogger<PessoaController> _logger;

        public PessoaController(ILogger<PessoaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            PessoaBusiness pessoalBLL = new PessoaBusiness();

            Console.WriteLine(pessoalBLL.ListarPessoas());
            ViewData["Pato"] = pessoalBLL.ListarPessoas();
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
