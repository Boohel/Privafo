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
    public class CityController : Controller
    {
        private readonly IUnitOfWork _uow;

        public CityController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        // GET: ProvinceController
        public ActionResult Index()
        {
            return View();
        }

        [NoDirectAccess]
        public async Task<IActionResult> Upsert(int? ID)
        {
            CityVM cityVM = new()
            {
                city = new(),
                countryList = _uow.Country.GetAll().Select(i => new SelectListItem
                {
                    Text = i.CountryName,
                    Value = i.ID.ToString()
                }),     
            };
           
            if (ID == null || ID == 0)
                return View(cityVM);
            else
            {
                
                cityVM.city = _uow.City.GetFirstOrDefault(u => u.ID == ID);
                int get1p = _uow.Province.GetFirstOrDefault(u => u.ID == cityVM.city.ProvinceID).CountryID;
                cityVM.countryId = get1p.ToString();
                //cityVM.countryList = _uow.Country.GetAll().Where(w => w.ID==8).Select(i => new SelectListItem
                //{
                //    Text = i.CountryName,
                //    Value = i.ID.ToString()
                //});
                cityVM.countryList = _uow.Country.GetAll().Select(i => new SelectListItem
                {
                    Text = i.CountryName,
                    Value = i.ID.ToString()
                });  
                cityVM.provinceList = _uow.Province.GetAll().Where(w => w.CountryID==get1p).Select(i => new SelectListItem
                {
                    Text = i.ProvinceName,
                    Value = i.ID.ToString()
                });
                return View(cityVM);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(CityVM obj)
        {
            if (ModelState.IsValid)
            {
                //Insert
                String resultMsg = "";
                if (obj.city.ID == 0 || obj.city.ID==null)
                {
                    _uow.City.Add(obj.city);
                    _uow.Save();
                    //TempData["success"] = "Vendor Product Category created successfully";
                    resultMsg = "City created successfully";
                }
                else
                {
                    _uow.City.Update(obj.city);
                    _uow.Save();
                    //TempData["success"] = "Vendor Product Category updated successfully";
                    resultMsg = "City updated successfully";
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", new City()), msg = resultMsg  });
            }
            else
            {
                return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "Upsert", new City()), msg = "Data Not Valid" });
            }
        }

        //POST
        [HttpDelete]
        public IActionResult Delete(int? ID)
        {
            var obj = _uow.City.GetFirstOrDefault(u => u.ID == ID);

            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _uow.City.Remove(obj);
            _uow.Save();
            return Json(new { success = true, message = "Province deleted successfully" });
        }

        [HttpGet]
        public IActionResult GetProvince(string country)
        {
            if (!string.IsNullOrWhiteSpace(country))
            {
                CityVM cityVM = new()
                {
                    provinceList = _uow.Province.GetAll(u => u.CountryID == Int64.Parse(country)).Select(i => new SelectListItem
                    {
                        Text = i.ProvinceName,
                        Value = i.ID.ToString()
                    })
                };
                return Json(cityVM);
            }
            return Json("");
        }

        [NoDirectAccess]
        public async Task<IActionResult> FilterData()
        {
            RiskThreat riskThreat = new();
            var filterField = new List<FilterField>
            {
                new FilterField
                {
                    type = "date",
                    id = "CreateDate",
                    label = "Date Created"
                },
            };
            return Json(new { fields = filterField });
        }

        #region API CALLS
        [HttpGet]
        [NoDirectAccess]
        public IActionResult GetAll(String jsonFilter)
        {
            var ProvinceList = _uow.City.GetAll(includeProperties: "Province");
            return Json(new { data = ProvinceList });
        }
        #endregion
    }
}

