using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Privafo.DataAccess;
using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using Privafo.Utility;
using static Privafo.Utility.Helper;

namespace PrivafoWeb.Controllers
{
    public class OrgSecMeasureController : Controller
    {
        private readonly IUnitOfWork _uow;

        public OrgSecMeasureController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        // GET: DteTransferController
        public ActionResult Index()
        {
            return View();
        }

        [NoDirectAccess]
        public async Task<IActionResult> Upsert(int ID = 0)
        {
            OrgSecMeasure orgSecMeasure = new();
            if (ID == 0)
                return View(orgSecMeasure);
            else
            {
                var OrgSecMeasureFromDbFirst = _uow.OrgSecMeasure.GetFirstOrDefault(u => u.ID == ID);
                if (OrgSecMeasureFromDbFirst == null)
                {
                    return NotFound();
                }
                return View(OrgSecMeasureFromDbFirst);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(OrgSecMeasure obj)
        {
            if (ModelState.IsValid)
            {
                //Insert
                String resultMsg = "";
                if (obj.ID == 0)
                {
                    _uow.OrgSecMeasure.Add(obj);
                    _uow.Save();
                    //TempData["success"] = "Vendor Product Category created successfully";
                    resultMsg = "Organize Security Measure created successfully";
                }
                else
                {
                    _uow.OrgSecMeasure.Update(obj);
                    _uow.Save();
                    //TempData["success"] = "Vendor Product Category updated successfully";
                    resultMsg = "Organize Security Measure updated successfully";
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", new OrgSecMeasure()), msg = resultMsg });
            }
            else
            {
                return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "Upsert", new OrgSecMeasure()), msg = "Data not Valid" });
            }
        }

        //POST
        [HttpDelete]
        public IActionResult Delete(int? ID)
        {
            var obj = _uow.OrgSecMeasure.GetFirstOrDefault(u => u.ID == ID);

            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _uow.OrgSecMeasure.Remove(obj);
            _uow.Save();
            return Json(new { success = true, message = "Organize Security Measure deleted successfully" });
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
            var OrgSecMeasureList = _uow.OrgSecMeasure.GetAll(includeProperties: "UserCreated");
            return Json(new { data = OrgSecMeasureList });
        }
        #endregion
    }
}
