using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Privafo.DataAccess;
using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using Privafo.Models.ViewModels;

namespace PrivafoWeb.Controllers
{
    public class RiskCtgController : Controller
    {
        private readonly IUnitOfWork _uow;

        public RiskCtgController(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public IActionResult Index()
        {
            return View();
        }

        //GET
        public IActionResult Upsert(int? ID)
        {
            RiskCtg riskCtg = new();
            if (ID == null || ID == 0)
            {
                return View(riskCtg);
            }
            else
            {
                riskCtg = _uow.RiskCtg.GetFirstOrDefault(u => u.ID == ID);
                return View(riskCtg);
            }
        }
        public class RiskCtgVM
        {
            public RiskCtg RiskCtg { get; set; }
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(RiskCtg obj)
        {
            if (ModelState.IsValid)
            {

                if (obj.ID == 0)
                {
                    _uow.RiskCtg.Add(obj);
                    _uow.Save();
                    TempData["success"] = "Risk Category created successfully";
                }
                else
                {
                    _uow.RiskCtg.Update(obj);
                    TempData["success"] = "Risk Category updated successfully";
                }
                _uow.Save();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //POST
        [HttpDelete]
        public IActionResult Delete(int? ID)
        {
            var obj = _uow.RiskCtg.GetFirstOrDefault(u => u.ID == ID);

            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _uow.RiskCtg.Remove(obj);
            _uow.Save();
            return Json(new { success = true, message = "Risk Category deleted successfully" });
        }


        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            var riskCtgList = _uow.RiskCtg.GetAll(includeProperties: "UserCreated");
            return Json(new { data = riskCtgList });
        }
        #endregion
    }
}
