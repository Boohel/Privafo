using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Privafo.DataAccess;
using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using Privafo.Models.ViewModels;
using Privafo.Utility;
using static Privafo.Utility.Helper;

namespace PrivafoWeb.Controllers
{
    public class CompanyStructureController : Controller
    {
        private readonly IUnitOfWork _uow;

        public CompanyStructureController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        // GET: CompanyStructureController
        public ActionResult Index()
        {
           //var data = new { atas = new { posisi1 = new { bawah = "ddd", bawah2 = "333" }, posisi2 = new { bawah2 = "ddd", bawah3 = "333" }, } };
           // ViewData["data"] = data;
            return View();
        }

        //[NoDirectAccess]
        public async Task<IActionResult> Upsert()
        {
            return View();
        }

    }
}

