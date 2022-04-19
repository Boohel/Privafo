using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Privafo.DataAccess;
using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using Privafo.Models.ViewModels;
using Newtonsoft.Json.Serialization;

namespace PrivafoWeb.Controllers
{
    public class RiskMatrixController : Controller
    {
        private readonly IUnitOfWork _uow;

        public RiskMatrixController(IUnitOfWork uow)
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
            ModuleVM moduleVM = new()
            {
                Module = new(),
                ModuleCtgSelectList = _uow.ModuleCtg.GetAll().Select(i => new SelectListItem
                {
                    Text = i.ModuleCtgName,
                    Value = i.ID.ToString()
                })
            };


            if (ID == null || ID == 0)
            {
                return View(moduleVM);
            }
            else
            {
                moduleVM.Module = _uow.Module.GetFirstOrDefault(u => u.ID == ID);

                return View(moduleVM);
            }
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(ModuleVM obj)
        {
            if (ModelState.IsValid)
            {

                if (obj.Module.ID == 0)
                {
                    _uow.Module.Add(obj.Module);
                    TempData["success"] = "Module inserted successfully";
                }
                else
                {
                    _uow.Module.Update(obj.Module);
                    TempData["success"] = "Module updated successfully";
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
            var obj = _uow.Module.GetFirstOrDefault(u => u.ID == ID);

            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _uow.Module.Remove(obj);
            _uow.Save();
            return Json(new { success = true, message = "Module deleted successfully" });
        }


        public class ScoreVM
        {
            public IEnumerable<RiskMatrixScore> RiskMxScore { get; set; }
        }

        #region API CALLS
        [HttpGet]
        public Microsoft.AspNetCore.Mvc.JsonResult GetAll()
        {
            ScoreVM modelList = new()
            {
                RiskMxScore = _uow.RiskMatrix.GetAll(
                orderBy: q => q.OrderByDescending(d => d.RiskProbability.LevelSort).OrderBy(d => d.RiskImpact.LevelSort),
                includeProperties: "RiskImpact,RiskProbability"
                )
            };

            //matrixList.Select(i => new { id = i.ID, score = i.Score, category = i.DateCreated }).ToList();

            return Json(modelList);
        }
        #endregion
    }
}
