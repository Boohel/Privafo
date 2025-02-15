using Microsoft.AspNetCore.Mvc;
using Privafo.DataAccess;
using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using Privafo.Utility;
using static Privafo.Utility.Helper;

namespace PrivafoWeb.Controllers
{
    public class PrivacyReqTypeController : Controller
    {
        private readonly IUnitOfWork _uow;

        public PrivacyReqTypeController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public ActionResult Index()
        {
            return View();
        }

        [NoDirectAccess]
        public async Task<IActionResult> Upsert(int ID = 0)
        {
            PrivacyReqType privacyReqType = new();
            if (ID == 0)
                return View(privacyReqType);
            else
            {
                var privacyReqTypeData = _uow.PrivacyReqType.GetFirstOrDefault(u => u.ID == ID);
                if (privacyReqTypeData == null)
                {
                    return NotFound();
                }
                return View(privacyReqTypeData);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(PrivacyReqType obj)
        {
            if (ModelState.IsValid)
            {
                String resultMsg = "";
                if (obj.ID == 0)
                {
                    _uow.PrivacyReqType.Add(obj);
                    _uow.Save();
                    resultMsg = "Privacy Request Type created successfully";
                }
                else
                {
                    _uow.PrivacyReqType.Update(obj);
                    _uow.Save();
                    resultMsg = "Privacy Request Type updated successfully";
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", new PrivacyReqType()), msg = resultMsg });
            }
            else
            {
                return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "Upsert", new PrivacyReqType()), msg = "Data not Valid" });
            }
        }

        //POST
        [HttpDelete]
        public IActionResult Delete(int? ID)
        {
            var obj = _uow.PrivacyReqType.GetFirstOrDefault(u => u.ID == ID);

            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _uow.PrivacyReqType.Remove(obj);
            _uow.Save();
            return Json(new { success = true, message = "Data Privacy Request Type deleted successfully" });
        }

        [NoDirectAccess]
        public async Task<IActionResult> FilterData()
        {
            PrivacyReqType privacyReqType = new();
            var filterField = new List<FilterField>
            {
                new FilterField
                {
                    type = "text",
                    id = "PrivacyReqTypeName",
                    label = "Privacy Request Type Name"
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
            var privacyReqTypeList = _uow.PrivacyReqType.GetAll(includeProperties: "UserCreated");
            return Json(new { data = privacyReqTypeList });
        }
        #endregion
    }
}
