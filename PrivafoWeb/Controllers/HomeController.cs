using Microsoft.AspNetCore.Mvc;
using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using System.Collections;
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

        [HttpGet]
        public IActionResult Index(int ID)
        {

            TempData["moduleid"] = ID;
            HttpContext.Session.SetInt32("_ModuleID", ID);
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
    }
}