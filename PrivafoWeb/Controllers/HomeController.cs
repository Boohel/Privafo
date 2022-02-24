using Microsoft.AspNetCore.Mvc;
using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using System.Diagnostics;

namespace PrivafoWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _uow;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork uow)
        {
            _logger = logger;
            _uow = uow;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome()
        {
            IEnumerable<Module> objModuleList = _uow.Module.GetAll();
            return View(objModuleList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}