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
    public class EntityController : Controller
    {
        private readonly IUnitOfWork _uow;

        public EntityController(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetProvince(string country)
        {
            if (!string.IsNullOrWhiteSpace(country))
            {
                EntityVM entityVM = new()
                {
                    provinceList = _uow.Province.GetAll(u => u.CountryID == Int64.Parse(country)).Select(i => new SelectListItem
                    {
                        Text = i.ProvinceName,
                        Value = i.ID.ToString()
                    })
                };
                return Json(entityVM);
            }
            return Json("");
        }

        [HttpGet]
        public IActionResult GetCity(string province)
        {
            if (!string.IsNullOrWhiteSpace(province))
            {
                EntityVM entityVM = new()
                {
                    cityList = _uow.City.GetAll(u => u.ProvinceID == Int64.Parse(province)).Select(i => new SelectListItem
                    {
                        Text = i.CityName,
                        Value = i.ID.ToString()
                    })
                };
                return Json(entityVM);
            }
            return Json("");
        }

        [NoDirectAccess]
        public async Task<IActionResult> Upsert(int ID = 0)
        {
            EntityVM entityVM = new()
            {
                entity = new(),
                address = new(),
                industryList = _uow.Industry.GetAll().Select(i => new SelectListItem
                {
                    Text = i.IndustryName,
                    Value = i.ID.ToString()
                }),
                countryList = _uow.Country.GetAll().Select(i => new SelectListItem
                {
                    Text = i.CountryName,
                    Value = i.ID.ToString()
                }),
            };
            if (ID == null || ID == 0)
                return View(entityVM);
            else
            {
                entityVM.entity = _uow.Entity.GetFirstOrDefault(u => u.ID == ID);
                entityVM.address = _uow.Address.GetFirstOrDefault(u => u.ID == entityVM.entity.AddressID);
                entityVM.cityId = entityVM.address.CityID.ToString();
                entityVM.provinceId = _uow.City.GetFirstOrDefault(u => u.ID == Int64.Parse(entityVM.cityId)).ProvinceID.ToString();
                entityVM.countryId = _uow.Province.GetFirstOrDefault(u => u.ID == Int64.Parse(entityVM.provinceId)).CountryID.ToString();
                entityVM.industryList = _uow.Industry.GetAll().Where(w => w.ID == entityVM.entity.IndustryID).Select(i => new SelectListItem
                {
                    Text = i.IndustryName,
                    Value = i.ID.ToString()
                });
                entityVM.cityList = _uow.City.GetAll().Where(w=> w.ProvinceID== Int64.Parse(entityVM.provinceId)).Select(i => new SelectListItem
                {
                    Text = i.CityName,
                    Value = i.ID.ToString()
                });
                entityVM.provinceList = _uow.Province.GetAll().Where(w => w.CountryID == Int64.Parse(entityVM.countryId)).Select(i => new SelectListItem
                {
                    Text = i.ProvinceName,
                    Value = i.ID.ToString()
                });
                entityVM.countryList = _uow.Country.GetAll().Select(i => new SelectListItem
                {
                    Text = i.CountryName,
                    Value = i.ID.ToString()
                });
                return View(entityVM);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(EntityVM obj)
        {
            if (ModelState.IsValid)
            {
                //Insert
                String resultMsg = "";
                if (obj.entity.ID == 0)
                {
                    Address saveAddress = new Address();
                    saveAddress.Add1 = obj.address.Add1;
                    saveAddress.Add2 = obj.address.Add2;
                    saveAddress.Add3 = obj.address.Add3;
                    saveAddress.Latitude = obj.address.Latitude;
                    saveAddress.Longitude = obj.address.Longitude;
                    saveAddress.CityID = obj.address.CityID;
                    saveAddress.PostCode = obj.address.PostCode;
                    _uow.Address.Add(saveAddress);
                    _uow.Save();

                    Entity saveEntity = new Entity();
                    saveEntity.EntityName = obj.entity.EntityName;
                    saveEntity.EntityPIC = obj.entity.EntityPIC;
                    saveEntity.BrandName = obj.entity.BrandName;
                    saveEntity.Phone = obj.entity.Phone;
                    saveEntity.MobilePhone = obj.entity.MobilePhone;
                    saveEntity.Email = obj.entity.Email;
                    saveEntity.Description = obj.entity.Description;
                    saveEntity.CreatedBy = obj.entity.CreatedBy;
                    saveEntity.UserCreated = obj.entity.UserCreated;
                    saveEntity.IndustryID = obj.entity.IndustryID;
                    saveEntity.AddressID = saveAddress.ID;
                    _uow.Entity.Add(saveEntity);
                    _uow.Save();
                    //TempData["success"] = "Vendor Product Category created successfully";
                    resultMsg = "Entity created successfully ";
                }
                else
                {
                    obj.address.ID = obj.entity.AddressID;                 
                    _uow.Address.Update(obj.address);
                    _uow.Save();

                    _uow.Entity.Update(obj.entity);
                    _uow.Save();
                    //TempData["success"] = "Vendor Product Category updated successfully";
                    resultMsg = "Entity updated successfully";
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", new Entity()), msg = resultMsg });
            }
            else
            {
                return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "Upsert", new Entity()), msg = "Data not Valid " });
            }
        }

        //POST
        [HttpDelete]
        public IActionResult Delete(int? ID)
        {
            var obj = _uow.Entity.GetFirstOrDefault(u => u.ID == ID);
            var addr = _uow.Address.GetFirstOrDefault(u => u.ID == obj.AddressID);

            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _uow.Address.Remove(addr);
            _uow.Entity.Remove(obj);
            _uow.Save();
            return Json(new { success = true, message = "Entity deleted successfully"  });
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
            var entityList = _uow.Entity.GetAll(includeProperties: "UserCreated");
            return Json(new { data = entityList });
        }
        #endregion
    }
}

