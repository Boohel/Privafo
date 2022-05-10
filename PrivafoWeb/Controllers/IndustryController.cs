using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Privafo.DataAccess;
using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using Privafo.Utility;
using static Privafo.Utility.Helper;

namespace PrivafoWeb.Controllers
{
    public class IndustryController : Controller
    {
        private readonly IUnitOfWork _uow;

        public IndustryController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        // GET: IndustryController
        public ActionResult Index()
        {
            return View();
        }

        [NoDirectAccess]
        public async Task<IActionResult> Upsert(int ID = 0)
        {
            Industry industry = new();
            if (ID == 0)
                return View(industry);
            else
            {
                var IndustryFromDbFirst = _uow.Industry.GetFirstOrDefault(u => u.ID == ID);
                if (IndustryFromDbFirst == null)
                {
                    return NotFound();
                }
                return View(IndustryFromDbFirst);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(Industry obj)
        {
            if (ModelState.IsValid)
            {
                //Insert
                String resultMsg = "";
                if (obj.ID == 0)
                {
                    _uow.Industry.Add(obj);
                    _uow.Save();
                    //TempData["success"] = "Vendor Product Category created successfully";
                    resultMsg = "Industry created successfully";
                }
                else
                {
                    _uow.Industry.Update(obj);
                    _uow.Save();
                    //TempData["success"] = "Vendor Product Category updated successfully";
                    resultMsg = "Industry updated successfully";
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", new Industry()), msg = resultMsg });
            }
            else
            {
                return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "Upsert", new Industry()), msg = "Data not Valid" });
            }
        }

        //POST
        [HttpDelete]
        public IActionResult Delete(int? ID)
        {
            var obj = _uow.Industry.GetFirstOrDefault(u => u.ID == ID);

            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _uow.Industry.Remove(obj);
            _uow.Save();
            return Json(new { success = true, message = "Industry deleted successfully" });
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
            var IndustryList = _uow.Industry.GetAll();
            return Json(new { data = IndustryList });
        }
        #endregion
    }
}

