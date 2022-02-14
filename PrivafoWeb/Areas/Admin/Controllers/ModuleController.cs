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
                    Value = i.ModuleCtgID.ToString()
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
                //ProductVM.Product = _unitOfwork.Product.GetFirstOrDefault(u => u.ID == ID);

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
                _uow.Module.Add(obj.Module);
                _uow.Save();
                TempData["success"] = "Category updated successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        public IActionResult Delete(int? ID)
        {
            if (ID == null || ID == 0)
            {
                return NotFound();
            }

            //var categoryFromDb = _db.Categories.Find(ID);
            var categoryFromDbFirst = _uow.ModuleCtg.GetFirstOrDefault(u => u.ModuleCtgID == ID);

            if (categoryFromDbFirst == null)
            {
                return NotFound();
            }
            return View(categoryFromDbFirst);
        }

        //POST
        [HttpPost, ActionName("Delete")] //ActionName("Delete") for define asp-action is "Delete"
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? ID)
        {
            var obj = _uow.ModuleCtg.GetFirstOrDefault(u => u.ModuleCtgID == ID);
            if (obj == null)
            {
                return NotFound();
            }

            _uow.ModuleCtg.Remove(obj);
            _uow.Save();
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
