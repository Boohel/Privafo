using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Privafo.DataAccess;
using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using Privafo.Utility;
using static Privafo.Utility.Helper;

namespace PrivafoWeb.Controllers
{
    public class DteCategoryController : Controller
    {
        private readonly IUnitOfWork _uow;

        public DteCategoryController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        // GET: VenProductCtgController
        public ActionResult Index()
        {
            return View();
        }

        [NoDirectAccess]
        public async Task<IActionResult> Upsert(int ID = 0)
        {
            DteCategory dteCtg = new();
            if (ID == 0)
                return View(dteCtg);
            else
            {
                var dtectgFromDbFirst = _uow.DteCategory.GetFirstOrDefault(u => u.ID == ID);
                if (dtectgFromDbFirst == null)
                {
                    return NotFound();
                }
                return View(dtectgFromDbFirst);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(DteCategory obj)
        {
            if (ModelState.IsValid)
            {
                //Insert
                String resultMsg = "";
                if (obj.ID == 0)
                {
                    _uow.DteCategory.Add(obj);
                    _uow.Save();
                    //TempData["success"] = "Vendor Product Category created successfully";
                    resultMsg = "Data Element Category created successfully";
                }
                else
                {
                    _uow.DteCategory.Update(obj);
                    _uow.Save();
                    //TempData["success"] = "Vendor Product Category updated successfully";
                    resultMsg = "Data Element Category updated successfully";
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", new DteCategory()), msg = resultMsg });
            }
            else
            {
                return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "Upsert", new DteCategory()), msg = "Data not Valid" });
            }
        }

        //POST
        [HttpDelete]
        public IActionResult Delete(int? ID)
        {
            var obj = _uow.DteCategory.GetFirstOrDefault(u => u.ID == ID);

            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _uow.DteCategory.Remove(obj);
            _uow.Save();
            return Json(new { success = true, message = "Data Element Category deleted successfully" });
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
            var dteCtgList = _uow.DteCategory.GetAll(includeProperties: "UserCreated");
            return Json(new { data = dteCtgList });
        }
        #endregion
    }
}

