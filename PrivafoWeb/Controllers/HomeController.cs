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


            //var cList = checkListRepository.GetAll().Where(p => p.isApproved && p.isHome);
            //var cat = checkListCategoryRepository.GetAll();
            //var model = new CheckListCatModel();
            //model.CheckLists = cList.ToList();
            //var query = from checkList in cList
            //            join category in cat on checkList.CategoryId equals category.Id
            //            select new CheckListCategory { Id = checkList.CategoryId, CategoryName = category.CategoryName };

            //model.Categories = query.ToList();
            //return View(model);
        }

        public IActionResult Welcome()
        {
            IEnumerable<Module> objModuleList = _uow.Module.GetAllFilter(i => i.ModuleCtgID == 3);

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