using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Privafo.DataAccess;
using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using Privafo.Models.ViewModels;

namespace PrivafoWeb.Components
{
    [ViewComponent(Name = "module")]
    public class ModuleViewComponent : ViewComponent
    {
        private readonly IUnitOfWork _uow;

        public ModuleViewComponent(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            NavModuleVM navModuleVM = new()
            {
                ModuleList = _uow.Module.GetAll(),
                ModuleCtgList = _uow.ModuleCtg.GetAll()
            };

            return View(navModuleVM);
        }
    }

    [ViewComponent(Name = "leftmenu")]
    public class LeftMenuViewComponent : ViewComponent
    {
        private readonly IUnitOfWork _uow;
        public LeftMenuViewComponent(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IViewComponentResult> InvokeAsync(int? moduleid)
        {
            if (moduleid == null) { moduleid = 0; };

            NavMenuVM navMenuVM = new()
            {
                MenuLevel1 = _uow.Menu.GetAllFilter(u => u.MenuGroup == "Level1" && u.ModuleID == moduleid),
                MenuLevel2 = _uow.Menu.GetAllFilter(u => u.MenuGroup == "Level2" && u.ModuleID == moduleid),
                MenuLevel3 = _uow.Menu.GetAllFilter(u => u.MenuGroup == "Level3" && u.ModuleID == moduleid)
            };

            return View(navMenuVM);
        }
    }
}
