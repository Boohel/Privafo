using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Privafo.DataAccess;
using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using Privafo.Models.ViewModels;
using static Privafo.Utility.Helper;

namespace PrivafoWeb.Controllers
{
    public class RiskRegisterController : Controller
    {
        private readonly IUnitOfWork _uow;

        public RiskRegisterController(IUnitOfWork uow)
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
            RiskRegisterVM riskRegisterVM = new()
            {
                RiskRegister = new(),
                RiskCtgList = _uow.RiskCtg.GetAll().Select(i => new SelectListItem
                {
                    Text = i.RiskCtgName,
                    Value = i.ID.ToString()
                }),
                RiskTypeList = _uow.RiskType.GetAll().Select(i => new SelectListItem
                {
                    Text = i.RiskTypeName,
                    Value = i.ID.ToString()
                }),
                RiskLibraryList = _uow.RiskLibrary.GetAll().Select(i => new SelectListItem
                {
                    Text = "",
                    Value = null
                }),
                OrganizationList = _uow.Organization.GetAll().Select(i => new SelectListItem
                {
                    Text = i.OrgName,
                    Value = i.ID.ToString()
                }),
                OwnerList = _uow.User.GetAll().Select(i => new SelectListItem
                {
                    Text = i.FirstName,
                    Value = i.Id.ToString()
                })
            };

            if (ID == null || ID == 0)
            {
                return View(riskRegisterVM);
            }
            else
            {
                riskRegisterVM.RiskRegister = _uow.RiskRegister.GetFirstOrDefault(u => u.ID == ID);

                return View(riskRegisterVM);
            }
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(RiskRegisterVM obj)
        {
            if (ModelState.IsValid) //validation form server side
            {

                if (obj.RiskRegister.ID == 0)
                {
                    _uow.RiskRegister.Add(obj.RiskRegister);
                    TempData["success"] = "Risk Register inserted successfully";
                }
                else
                {
                    _uow.RiskRegister.Update(obj.RiskRegister);
                    TempData["success"] = "Risk Register updated successfully";
                }
                _uow.Save();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        public IActionResult Detail(int? ID)
        {

            var RiskRegisterData = _uow.RiskRegister.GetFirstOrDefault(filter : u => u.ID == ID, includeProperties: "RiskType,ResidualRiskScore,InherentRiskScore,UserOwner,Org");
                        
            var rangeResidualScore = _uow.RiskRangeScore.GetFirstOrDefault(u => u.MinRange <= RiskRegisterData.ResidualRiskScore.Score && u.MaxRange >= RiskRegisterData.ResidualRiskScore.Score);
            RiskRegisterData.ResidualRiskLvl = rangeResidualScore.RiskLevel;
            RiskRegisterData.ResidualRiskColor = rangeResidualScore.RangeColor;

            var rangeInherentScore = _uow.RiskRangeScore.GetFirstOrDefault(u => u.MinRange <= RiskRegisterData.InherentRiskScore.Score && u.MaxRange >= RiskRegisterData.InherentRiskScore.Score);
            RiskRegisterData.InherentRiskLvl = rangeInherentScore.RiskLevel;
            RiskRegisterData.InherentRiskColor = rangeResidualScore.RangeColor;

            return View(RiskRegisterData);
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


        [NoDirectAccess]
        public async Task<IActionResult> FilterData()
        {
            RiskThreat riskThreat = new();
            var filterField = new List<FilterField>
            {
                new FilterField
                {
                    type = "text",
                    id = "RiskRegName",
                    label = "Risk Register Name"
                },
                new FilterField
                {
                    type = "date",
                    id = "CreateDate",
                    label = "Date Created"
                }
            };
            return Json(new { fields = filterField });
        }

        #region API CALLS

        [HttpGet]
        [NoDirectAccess]
        public IActionResult GetAll(String jsonFilter)
        {
            var riskRegList = _uow.RiskRegister.GetAll(includeProperties: "RiskType,ResidualRiskScore,InherentRiskScore,UserOwner,Org");

            foreach (var score in riskRegList)
            {
                var rangeResidualScore = _uow.RiskRangeScore.GetFirstOrDefault(u => u.MinRange <= score.ResidualRiskScore.Score && u.MaxRange >= score.ResidualRiskScore.Score);
                score.ResidualRiskLvl = rangeResidualScore.RiskLevel;
                score.ResidualRiskColor = rangeResidualScore.RangeColor;

                var rangeInherentScore = _uow.RiskRangeScore.GetFirstOrDefault(u => u.MinRange <= score.InherentRiskScore.Score && u.MaxRange >= score.InherentRiskScore.Score);
                score.InherentRiskLvl = rangeInherentScore.RiskLevel;
                score.InherentRiskColor = rangeResidualScore.RangeColor;
            }

            return Json(new { data = riskRegList });
        }

        [HttpGet]
        [NoDirectAccess]
        public IActionResult GetRiskLibraries(string riskType)
        {
            if (!string.IsNullOrWhiteSpace(riskType))
            {
                RiskRegisterVM riskRegisterVM = new()
                {
                    RiskLibraryList = _uow.RiskLibrary.GetAll(u => u.RiskTypeID == Int64.Parse(riskType)).Select(i => new SelectListItem
                    {
                        Text = i.RiskLibName,
                        Value = i.ID.ToString()
                    })
                };
                return Json(riskRegisterVM);
            }
            return null;
        }

        #endregion
    }
}
