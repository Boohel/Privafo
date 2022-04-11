using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Privafo.DataAccess;
using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using Privafo.Utility;
using static Privafo.Utility.Helper;

namespace PrivafoWeb.Controllers
{
    public class RiskThreatController : Controller
    {
        private readonly IUnitOfWork _uow;

        public RiskThreatController(IUnitOfWork uow)
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
            RiskThreat riskThreat = new();
            if (ID == 0)
                return View(riskThreat);
            else
            {
                var riskThreatFromDbFirst = _uow.RiskThreat.GetFirstOrDefault(u => u.ID == ID);
                if (riskThreatFromDbFirst == null)
                {
                    return NotFound();
                }
                return View(riskThreatFromDbFirst);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(RiskThreat obj)
        {
            if (ModelState.IsValid)
            {
                //Insert
                String resultMsg = "";
                if (obj.ID == 0)
                {
                    _uow.RiskThreat.Add(obj);
                    _uow.Save();
                    //TempData["success"] = "Risk Threat created successfully";
                    resultMsg = "Risk Threat created successfully";
                }
                else
                {
                    _uow.RiskThreat.Update(obj);
                    _uow.Save();
                    //TempData["success"] = "Risk Threat updated successfully";
                    resultMsg = "Risk Threat updated successfully";
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", new RiskThreat()), msg = resultMsg });
            }
            else
            {
                return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "Upsert", new RiskThreat()), msg = "Data not Valid" });
            }
        }

        //POST
        [HttpDelete]
        public IActionResult Delete(int? ID)
        {
            var obj = _uow.RiskThreat.GetFirstOrDefault(u => u.ID == ID);

            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _uow.RiskThreat.Remove(obj);
            _uow.Save();
            return Json(new { success = true, message = "Risk Threat deleted successfully" });
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
                    id = "ThreatName",
                    label = "Threat Name"
                },
                new FilterField
                {
                    type = "date",
                    id = "CreateDate",
                    label = "Date Created"
                },
                new FilterField
                {
                    type = "list",
                    id = "TestList",
                    label = "Test List",
                    list = new List<FilterListItem>
                    {
                        new FilterListItem
                        {
                            id = "1",
                            label = "A"
                        },
                        new FilterListItem
                        {
                            id = "2",
                            label = "B"
                        },
                        new FilterListItem
                        {
                            id = "3",
                            label = "C"
                        }
                    }
                }
            };
            return Json(new { fields = filterField });
        }

        #region API CALLS
        [HttpGet]
        [NoDirectAccess]
        public IActionResult GetAll(String jsonFilter)
        {
            var riskThreatList = _uow.RiskThreat.GetAll(includeProperties: "UserCreated");
            return Json(new { data = riskThreatList });
        }
        #endregion
    }
}
