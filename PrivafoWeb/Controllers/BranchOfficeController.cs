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
    public class BranchOfficeController : Controller
    {
        private readonly IUnitOfWork _uow;

        public BranchOfficeController(IUnitOfWork uow)
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
                BranchVM branchVM = new()
                {
                    provinceList = _uow.Province.GetAll(u => u.CountryID == Int64.Parse(country)).Select(i => new SelectListItem
                    {
                        Text = i.ProvinceName,
                        Value = i.ID.ToString()
                    }),
                     entitiesList = _uow.Entity.GetAll().Select(i => new SelectListItem
                     {
                         Text = i.BrandName,
                         Value = i.ID.ToString()
                     })
                };
                return Json(branchVM);
            }
            return Json("");
        }

        [HttpGet]
        public IActionResult GetCity(string province)
        {
            if (!string.IsNullOrWhiteSpace(province))
            {
                BranchVM branchVM = new()
                {
                    cityList = _uow.City.GetAll(u => u.ProvinceID == Int64.Parse(province)).Select(i => new SelectListItem
                    {
                        Text = i.CityName,
                        Value = i.ID.ToString()
                    })
                };
                return Json(branchVM);
            }
            return Json("");
        }

        [NoDirectAccess]
        public async Task<IActionResult> Upsert(int ID = 0)
        {
            BranchVM branchVM = new()
            {
                branch = new(),
                address = new(),
                countryList = _uow.Country.GetAll().Select(i => new SelectListItem
                {
                    Text = i.CountryName,
                    Value = i.ID.ToString()
                }),
                entitiesList = _uow.Entity.GetAll().Select(i => new SelectListItem
                {
                    Text = i.BrandName,
                    Value = i.ID.ToString()
                })
            };
            if (ID == null || ID == 0)
                return View(branchVM);
            else
            {
                branchVM.branch = _uow.Branch.GetFirstOrDefault(u => u.ID == ID);
                branchVM.address = _uow.Address.GetFirstOrDefault(u => u.ID == branchVM.branch.AddressID);
                branchVM.cityId = branchVM.address.CityID.ToString();
                branchVM.provinceId = _uow.City.GetFirstOrDefault(u => u.ID == Int64.Parse(branchVM.cityId)).ProvinceID.ToString();
                branchVM.countryId = _uow.Province.GetFirstOrDefault(u => u.ID == Int64.Parse(branchVM.provinceId)).CountryID.ToString();
                branchVM.entitiesList = _uow.Entity.GetAll().Where(w => w.ID == branchVM.branch.EntityID).Select(i => new SelectListItem
                {
                    Text = i.EntityName,
                    Value = i.ID.ToString()
                });
                branchVM.cityList = _uow.City.GetAll().Where(w=> w.ProvinceID== Int64.Parse(branchVM.provinceId)).Select(i => new SelectListItem
                {
                    Text = i.CityName,
                    Value = i.ID.ToString()
                });
                branchVM.provinceList = _uow.Province.GetAll().Where(w => w.CountryID == Int64.Parse(branchVM.countryId)).Select(i => new SelectListItem
                {
                    Text = i.ProvinceName,
                    Value = i.ID.ToString()
                });
                 branchVM.countryList = _uow.Country.GetAll().Select(i => new SelectListItem
                {
                    Text = i.CountryName,
                    Value = i.ID.ToString()
                });
                return View(branchVM);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(BranchVM obj)
        {
            if (ModelState.IsValid)
            {
                //Insert
                String resultMsg = "bisa";
                if (obj.branch.ID == 0)
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

                    Branch savebranch = new Branch();
                    savebranch.BranchCode = obj.branch.BranchCode;
                    savebranch.BranchName = obj.branch.BranchName;
                    savebranch.BranchPIC = obj.branch.BranchPIC;
                    savebranch.Phone = obj.branch.Phone;
                    savebranch.MobilePhone = obj.branch.MobilePhone;
                    savebranch.Email = obj.branch.Email;
                    savebranch.Description = obj.branch.Description;
                    savebranch.CreatedBy = obj.branch.CreatedBy;
                    savebranch.UserCreated = obj.branch.UserCreated;
                    savebranch.EntityID = obj.branch.EntityID;
                    savebranch.AddressID = saveAddress.ID;
                    _uow.Branch.Add(savebranch);
                    _uow.Save();
                    //TempData["success"] = "Vendor Product Category created successfully";
                    resultMsg = "Branch Office created successfully ";
                }
                else
                {
                    obj.address.ID = obj.branch.AddressID;
                    _uow.Address.Update(obj.address);
                    _uow.Save();

                    _uow.Branch.Update(obj.branch);
                    _uow.Save();
                    //TempData["success"] = "Vendor Product Category updated successfully";
                    resultMsg = "Branch Office updated successfully";
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", new Branch()), msg = resultMsg });
            }
            else
            {
                return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "Upsert", new Branch()), msg = "Data not Valid " });
            }
        }

        //POST
        [HttpDelete]
        public IActionResult Delete(int? ID)
        {
            var obj = _uow.Branch.GetFirstOrDefault(u => u.ID == ID);
            var addr = _uow.Address.GetFirstOrDefault(u => u.ID == obj.AddressID);

            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _uow.Address.Remove(addr);
            _uow.Branch.Remove(obj);
            _uow.Save();
            return Json(new { success = true, message = "Branch deleted successfully"  });
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
            var bracnhList = _uow.Branch.GetAll(includeProperties: "UserCreated");
            return Json(new { data = bracnhList });
        }
        #endregion
    }
}

