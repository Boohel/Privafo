using Microsoft.AspNetCore.Mvc;
using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using Privafo.Utility;
using System.Collections;
using System.Diagnostics;

namespace PrivafoWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _uow;
        private readonly IConfiguration _config;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork uow, IConfiguration config)
        {
            _logger = logger;
            _uow = uow;
            _config = config;
        }

        [HttpGet]
        public IActionResult Index(int ID)
        {
            var obj = _uow.Module.GetFirstOrDefault(u => u.ID == ID);
            
            HttpContext.Session.SetInt32(SD.sesModule, ID);
            HttpContext.Session.SetString(SD.sesModuleName, obj.ModuleName);

            ViewData["username"]= _config.GetSection("byPassAccount").GetSection("username").Value;

            return View();
        }


        public IActionResult Welcome()
        {
            IEnumerable<Module> objModuleList = _uow.Module.GetAllFilter(i => i.Highlight);

            return View(objModuleList);
        }


        public class BasicVM
        {
            public IEnumerable<Module> Data1 { get; set; }
            public IEnumerable<Module> Data2 { get; set; }
            public IEnumerable<Module> Data3 { get; set; }
            public IEnumerable<Module> Data4 { get; set; }
            public IEnumerable<Module> Data5 { get; set; }
        }

        public class PostMenuName
        {
            public string menuName { get; set; }
        }

        [HttpPost]
        public IActionResult SetSessionMenu([FromBody] PostMenuName request) 
        {
            HttpContext.Session.SetString("menu", request.menuName);

            return Json(new { data = request.menuName });
        }

        public IActionResult Privacy()
        {
            // basic Model
            Module module = new();
            //return View(module);

            // like expression 
            var data1 = _uow.Module.GetAllFilter(u => u.ModuleName!.Contains("test"), includeProperties: "ModuleCtg");

            // and or expression 
            var data2 = _uow.Module.GetAllFilter(u => (u.ModuleName == "string" && u.ModuleCtg.ModuleCtgName == "string") || u.ModuleName!.Contains("test"), includeProperties: "ModuleCtg");

            // custom select
            var data3 = _uow.Module.GetAll(includeProperties: "ModuleCtg")
                .Select(i => new { name = i.ModuleName, desc = i.Description, category = i.ModuleCtg.ModuleCtgName });

            // group by
            var data4 = _uow.Module.GetAll(includeProperties: "ModuleCtg")
                .GroupBy(j => new { j.ModuleCtgID });

            // order by
            var data5 = _uow.Module.GetAll(includeProperties: "ModuleCtg")
                .OrderBy(j => new { j.ModuleCtgID })
                .OrderByDescending(j => new { j.ModuleSort });

            // ViewBag & ViewData Mode
            ViewBag.ModuleList = data4;
            ViewData["ModuleList"] = data5;

            BasicVM basicVM = new()
            {
                Data1 = _uow.Module.GetAllFilter(u => u.ModuleName!.Contains("test"), includeProperties: "ModuleCtg"),
                Data2 = _uow.Module.GetAllFilter(u => (u.ModuleName == "string" && u.ModuleCtg.ModuleCtgName == "string") || u.ModuleName!.Contains("test"), includeProperties: "ModuleCtg"),
                Data3 = (IEnumerable<Module>)_uow.Module.GetAll(includeProperties: "ModuleCtg")
                        .Select(i => new { name = i.ModuleName, desc = i.Description, category = i.ModuleCtg.ModuleCtgName }),
                Data4 = (IEnumerable<Module>)_uow.Module.GetAll(includeProperties: "ModuleCtg")
                        .GroupBy(j => new { j.ModuleCtgID }),
                Data5 = (IEnumerable<Module>)_uow.Module.GetAll(includeProperties: "ModuleCtg")
                        .GroupBy(j => new { j.ModuleCtgID })
            };

            return View(basicVM);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("/Home/HandleError/{code:int}")]
        public IActionResult HandleError(int code)
        {
            if(code == 404)
            {
                ViewData["ErrorMessage"] = $"Error occurred. The ErrorCode is: {code}";
                return View("~/Views/Shared/_UnderContruction.cshtml");
            }
            else
            {
                return View("~/Views/Shared/Error.cshtml");
            }
        }
    }
}