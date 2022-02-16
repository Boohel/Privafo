using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Privafo.DataAccess;
using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using Privafo.Models.ViewModels;

namespace PrivafoWeb.Controllers
{
    public class ModuleController : Controller
    {
        private readonly IUnitOfWork _uow;

        public ModuleController(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public IActionResult Index()
        {
            return View();
        }

        //GET
        public IActionResult Upsert(int? ID)
        {
            //Module module = new();
            //IEnumerable<SelectListItem> ModuleCtgList = _uow.ModuleCtg.GetAll().Select(i => new SelectListItem
            //{
            //    Text = i.ModuleCtgName,
            //    Value = i.ModuleCtgID.ToString()
            //});

            ModuleVM moduleVM = new()
            {
                Module = new(),
                ModuleCtgList = _uow.ModuleCtg.GetAll().Select(i => new SelectListItem
                {
                    Text = i.ModuleCtgName,
                    Value = i.ID.ToString()
                })
            };


            if (ID == null || ID == 0)
            {
                //Create Product

                ////ViewBag Mode
                //ViewBag.ModuleCtgList = ModuleCtgList;
                //ViewData["ModuleCtgList"] = ModuleCtgList;
                //return View(module);

                //ViewModel Mode
                return View(moduleVM);
            }
            else
            {
                moduleVM.Module = _uow.Module.GetFirstOrDefault(u => u.ID == ID);

                return View(moduleVM);
            }
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(ModuleVM obj)
        {
            if (ModelState.IsValid) //validation form server side
            {

                if (obj.Module.ID == 0)
                {
                    _uow.Module.Add(obj.Module);
                    TempData["success"] = "Module inserted successfully";
                }
                else
                {
                    _uow.Module.Update(obj.Module);
                    TempData["success"] = "Module updated successfully";
                }
                _uow.Save();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //POST
        [HttpDelete]
        public IActionResult Delete(int? ID)
        {
            var obj = _uow.Module.GetFirstOrDefault(u => u.ID == ID);

            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _uow.Module.Remove(obj);
            _uow.Save();
            return Json(new { success = true, message = "Module deleted successfully" });
        }


        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            //var productList = _uow.Module.GetAll();
            var productList = _uow.Module.GetAll(includeProperties: "ModuleCtg");
            return Json(new { data = productList });
        }
        #endregion
    }
}
