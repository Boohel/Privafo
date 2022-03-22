using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Privafo.DataAccess;
using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using Privafo.Models.ViewModels;

namespace PrivafoWeb.Controllers
{
    public class DPIAController : Controller
    {
        private readonly IUnitOfWork _uow;

        public DPIAController(IUnitOfWork uow)
        {
            _uow = uow;
        }
        //GET
        public IActionResult Index()
        {
            return View();
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(DPIAVM obj)
        {
            //if (ModelState.IsValid) //validation form server side
            //{

                if (obj.DPIATemplate.ID == 0)
                {
                    _uow.DPIATemplate.Add(obj.DPIATemplate);
                    TempData["success"] = ",DPIA Template inserted successfully";
                }
                else
                {
                    _uow.DPIATemplate.Update(obj.DPIATemplate);
                    TempData["success"] = "DPIA Template updated successfully";
                }
                _uow.Save();
                return RedirectToAction("Index");
            //}
            //return View(obj);
        }

        //GET
        public IActionResult Upsert(int? ID)
        {
            DPIAVM DPIAVM = new()
            {
                DPIATemplate = new(),
                //ModuleCtgSelectList = _uow.ModuleCtg.GetAll().Select(i => new SelectListItem
                //{
                //    Text = i.ModuleCtgName,
                //    Value = i.ID.ToString()
                //})
            };


            if (ID == null || ID == 0)
            {
                //Create Product

                ////ViewBag Mode
                //ViewBag.ModuleCtgList = ModuleCtgList;
                //ViewData["ModuleCtgList"] = ModuleCtgList;
                //return View(module);

                //ViewModel Mode
                return View(DPIAVM);
            }
            else
            {
                DPIAVM.DPIATemplate = _uow.DPIATemplate.GetFirstOrDefault(u => u.ID == ID);

                return View(DPIAVM);
            }
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(DPIAVM obj)
        {
            //if (ModelState.IsValid) //validation form server side
            //{

                if (obj.DPIATemplate.ID == 0)
                {
                    _uow.DPIATemplate.Add(obj.DPIATemplate);
                    TempData["success"] = ",DPIA Template inserted successfully";
                }
                else
                {
                    _uow.DPIATemplate.Update(obj.DPIATemplate);
                    TempData["success"] = "DPIA Template updated successfully";
                }
                _uow.Save();
                return RedirectToAction("Index");
            //}
            //return View(obj);
        }

        //POST
        [HttpDelete]
        public IActionResult Delete(int? ID)
        {
            var obj = _uow.DPIATemplate.GetFirstOrDefault(u => u.ID == ID);

            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _uow.DPIATemplate.Remove(obj);
            _uow.Save();
            return Json(new { success = true, message = "DPIA Template deleted successfully" });
        }


        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            //var productList = _uow.Module.GetAll();
            var productList = _uow.DPIATemplate.GetAll();
            return Json(new { data = productList });
        }

        public IActionResult GetAllCustom()
        {
            //var productList = _uow.Module.GetAll();
            var productList = _uow.DPIATemplate.GetAll().Select(i => new { name = i.TemplateName, desc = i.Description } );
            return Json(new { data = productList });
        }
        #endregion

    }
}
