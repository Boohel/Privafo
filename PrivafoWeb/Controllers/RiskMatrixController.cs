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
            public double TotalImpact { get; set; }
            public double TotalProb { get; set; }
        }

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            ScoreVM modelList = new()
            {
                RiskMxScore = _uow.RiskMatrix.GetAll(
                    orderBy: q => q.OrderByDescending(d => d.RiskImpact.LevelSort).ThenBy(d => d.RiskProbability.LevelSort),
                    includeProperties: "RiskImpact,RiskProbability"
                ),
                TotalImpact = _uow.RiskImpact.GetAll().Count(),
                TotalProb = _uow.RiskProbability.GetAll().Count()
            };

            foreach (var score in modelList.RiskMxScore)
            {
                var rangeScore = _uow.RiskRangeScore.GetFirstOrDefault(u => u.MinRange <= score.Score && u.MaxRange >= score.Score);
                score.LvlScoreName = rangeScore.RiskLevel;
                score.LvlScoreColor = rangeScore.RangeColor;
            }

            return Json(modelList);
        }
        #endregion
    }
}
