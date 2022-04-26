using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Privafo.DataAccess;
using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using Privafo.Utility;
using static Privafo.Utility.Helper;

namespace PrivafoWeb.Controllers
{
    public class VenProductTypeController : Controller
    {
        private readonly IUnitOfWork _uow;

        public VenProductTypeController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        // GET: VenProductTypeController
        public ActionResult Index()
        {
            return View();
        }

        [NoDirectAccess]
        public async Task<IActionResult> Upsert(int ID = 0)
        {
            VendorType venType = new();
            if (ID == 0)
                return View(venType);
            else
            {
                var venTypeFromDbFirst = _uow.VendorType.GetFirstOrDefault(u => u.ID == ID);
                if (venTypeFromDbFirst == null)
                {
                    return NotFound();
                }
                return View(venTypeFromDbFirst);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(VendorType obj)
        {
            if (ModelState.IsValid)
            {
                //Insert
                String resultMsg = "";
                if (obj.ID == 0)
                {
                    _uow.VendorType.Add(obj);
                    _uow.Save();
                    //TempData["success"] = "Vendor Type created successfully";
                    resultMsg = "Vendor Type created successfully";
                }
                else
                {
                    _uow.VendorType.Update(obj);
                    _uow.Save();
                    //TempData["success"] = "Vendor Type updated successfully";
                    resultMsg = "Vendor Type updated successfully";
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", new VendorType()), msg = resultMsg });
            }
            else
            {
                return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "Upsert", new VendorType()), msg = "Data not Valid" });
            }
        }

        //POST
        [HttpDelete]
        public IActionResult Delete(int? ID)
        {
            var obj = _uow.VendorType.GetFirstOrDefault(u => u.ID == ID);

            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _uow.VendorType.Remove(obj);
            _uow.Save();
            return Json(new { success = true, message = "Vendor Type deleted successfully" });
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
            var VendorTypeList = _uow.VendorType.GetAll(includeProperties: "UserCreated");
            return Json(new { data = VendorTypeList });
        }
        #endregion
    }
}
