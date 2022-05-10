using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Privafo.DataAccess;
using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using Privafo.Models.ViewModels;
using Privafo.Utility;
using static Privafo.Utility.Helper;

namespace PrivafoWeb.Controllers
{
    public class DataElementController : Controller
    {
        private readonly IUnitOfWork _uow;

        public DataElementController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        // GET: DataElementController
        public ActionResult Index()
        {
            return View();
        }

        [NoDirectAccess]
        public async Task<IActionResult> Upsert(int? ID)
        {
            DataElementVM dataElementVM = new()
            {
                dataElement = new(),
                categorylist = _uow.DteCategory.GetAll().Select(i => new SelectListItem
                {
                    Text = i.DteCtgName,
                    Value = i.ID.ToString()
                }),
            };

           
            if (ID == null || ID == 0)
                return View(dataElementVM);
            else
            {
                dataElementVM.dataElement = _uow.DataElement.GetFirstOrDefault(u => u.ID == ID);
                return View(dataElementVM);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(DataElementVM obj)
        {
            if (ModelState.IsValid)
            {
                //Insert
                String resultMsg = "";
                if (obj.dataElement.ID == 0)
                {
                    _uow.DataElement.Add(obj.dataElement);
                    _uow.Save();
                    //TempData["success"] = "Vendor Product Category created successfully";
                    resultMsg = "Data Element created successfully";
                }
                else
                {
                    _uow.DataElement.Update(obj.dataElement);
                    _uow.Save();
                    //TempData["success"] = "Vendor Product Category updated successfully";
                    resultMsg = "Data element updated successfully";
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", new DataElement()), msg = resultMsg });
            }
            else
            {
                return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "Upsert", new DataElement()), msg = "Data Not Valid" });
            }
        }

        //POST
        [HttpDelete]
        public IActionResult Delete(int? ID)
        {
            var obj = _uow.DataElement.GetFirstOrDefault(u => u.ID == ID);

            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _uow.DataElement.Remove(obj);
            _uow.Save();
            return Json(new { success = true, message = "Data Element deleted successfully" });
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
        //[NoDirectAccess]
        public IActionResult GetAll(String jsonFilter)
        {
            var DataElementList = _uow.DataElement.GetAll(includeProperties: "DteCategory");
            return Json(new { data = DataElementList });
        }
        #endregion
    }
}

