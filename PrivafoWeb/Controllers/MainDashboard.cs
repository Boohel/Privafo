using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Privafo.DataAccess;
using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using Privafo.Models.ViewModels;
using Newtonsoft.Json.Serialization;

namespace PrivafoWeb.Controllers
{
    public class MainDashboardController : Controller
    {
        private readonly IUnitOfWork _uow;

        public MainDashboardController(IUnitOfWork uow)
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
