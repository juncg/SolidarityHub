using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PRUEBAS.Data;
using PRUEBAS.Models;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PRUEBAS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult CreateAfectado()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAfectado(Afectado afectado)
        {
            if (ModelState.IsValid)
            {
                _context.Afectados.Add(afectado);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(afectado);
        }

        public IActionResult MapAfectados()
        {
            return View();
        }

        public IActionResult ListAfectados()
        {
            var afectados = _context.Afectados.ToList();
            return View(afectados);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}