using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Privafo.DataAccess;
using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using Privafo.Utility;
using static Privafo.Utility.Helper;

namespace PrivafoWeb.Controllers
{
    public class RiskTypeController : Controller
    {
        private readonly IUnitOfWork _uow;

        public RiskTypeController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        // GET: RiskThreatController
        public ActionResult Index()
        {
            return View();
        }

        [NoDirectAccess]
        public async Task<IActionResult> Upsert(int ID = 0)
        {
            RiskType riskType = new();
            if (ID == 0)
                return View(riskType);
            else
            {
                var riskTypeFromDbFirst = _uow.RiskType.GetFirstOrDefault(u => u.ID == ID);
                if (riskTypeFromDbFirst == null)
                {
                    return NotFound();
                }
                return View(riskTypeFromDbFirst);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(RiskType obj)
        {
            if (ModelState.IsValid)
            {
                String resultMsg = "";
                if (obj.ID == 0)
                {
                    _uow.RiskType.Add(obj);
                    _uow.Save();
                    //TempData["success"] = "Risk Threat created successfully";
                    resultMsg = "Risk Type created successfully";
                }
                else
                {
                    _uow.RiskType.Update(obj);
                    _uow.Save();
                    //TempData["success"] = "Risk Threat updated successfully";
                    resultMsg = "Risk Type updated successfully";
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", new RiskType()), msg = resultMsg });
            }
            else
            {
                return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "Upsert", new RiskType()), msg = "Data not Valid" });
            }
        }

        //POST
        [HttpDelete]
        public IActionResult Delete(int? ID)
        {
            var obj = _uow.RiskType.GetFirstOrDefault(u => u.ID == ID);

            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _uow.RiskType.Remove(obj);
            _uow.Save();
            return Json(new { success = true, message = "Risk Type deleted successfully" });
        }

        [NoDirectAccess]
        public async Task<IActionResult> FilterData()
        {
            RiskType riskType = new();
            var filterField = new List<FilterField>
            {
                new FilterField
                {
                    type = "text",
                    id = "RiskTypeName",
                    label = "Risk Type Name"
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
            var riskTypeList = _uow.RiskType.GetAll(includeProperties: "UserCreated");
            return Json(new { data = riskTypeList });
        }
        #endregion
    }
}
