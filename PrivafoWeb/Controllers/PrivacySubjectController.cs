using Microsoft.AspNetCore.Mvc;
using Privafo.DataAccess;
using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;

namespace PrivafoWeb.Controllers
{
    public class PrivacySubjectController : Controller
    {
        private readonly IUnitOfWork _uow;

        public PrivacySubjectController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public IActionResult Index()
        {
            IEnumerable<ModuleCtg> objModuleCtgList = _uow.ModuleCtg.GetAll();
            return View(objModuleCtgList);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ModuleCtg obj)
        {
            if (ModelState.IsValid) //validation form server side
            {
                _uow.ModuleCtg.Add(obj);
                _uow.Save();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        public IActionResult Edit(int? ID)
        {
            if (ID == null || ID == 0)
            {
                return NotFound();
            }

            //var modulectgData = _db.module_ctg.Find(ID);
            var modulectgFromDbFirst = _uow.ModuleCtg.GetFirstOrDefault(u => u.ID == ID);
            //var modulectgFromDbSingle = _db.module_ctg.SingleOrDefault(u => u.ID==ID);

            if (modulectgFromDbFirst == null)
            {
                return NotFound();
            }
            return View(modulectgFromDbFirst);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ModuleCtg obj)
        {
            if (ModelState.IsValid) //validation form server side
            {
                _uow.ModuleCtg.Update(obj);
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
            var categoryFromDbFirst = _uow.ModuleCtg.GetFirstOrDefault(u => u.ID == ID);

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
            var obj = _uow.ModuleCtg.GetFirstOrDefault(u => u.ID == ID);
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
