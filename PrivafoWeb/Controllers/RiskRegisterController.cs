using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Privafo.DataAccess;
using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using Privafo.Models.ViewModels;

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
                RiskLibrary = _uow.RiskLibrary.GetAll().Select(i => new SelectListItem
                {
                    Text = "",
                    Value = null
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
        public IActionResult Upsert(ModuleVM obj)
        {
            if (ModelState.IsValid) //validation form server side
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


        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            //var productList = _uow.Module.GetAll();
            var riskRegList = _uow.RiskRegister.GetAll(includeProperties: "RiskType,ResidualRiskScore,InherentRiskScore,UserOwner,Org");
            //return Json(new { data = riskRegList });
            return Json(riskRegList);
        }

        [HttpGet]
        public IActionResult GetRiskLibraries(string riskType)
        {
            if (!string.IsNullOrWhiteSpace(riskType))
            {
                RiskRegisterVM riskRegisterVM = new()
                {
                    RiskLibrary = _uow.RiskLibrary.GetAll(u => u.RiskTypeID == Int64.Parse(riskType)).Select(i => new SelectListItem
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
