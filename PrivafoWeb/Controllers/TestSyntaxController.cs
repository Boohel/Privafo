using Microsoft.AspNetCore.Mvc;
using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using Privafo.Utility;
using System.Collections;
using System.Diagnostics;
using System.Security.Claims;

namespace PrivafoWeb.Controllers
{
    public class TestSyntaxController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _uow;
        private readonly IConfiguration _config;

        public TestSyntaxController(ILogger<HomeController> logger, IUnitOfWork uow, IConfiguration config)
        {
            _logger = logger;
            _uow = uow;
            _config = config;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

    }
}