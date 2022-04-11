using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
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
    [Authorize]
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
                //MenuLevel1 = _uow.Menu.GetAll().Select(i => new { i.ID, i.MenuName, i.MenuLevel, i.AreaName, i.ControllerName, i.ActionName, i.PageName}).Where(u => u.MenuLevel == 1 && u.ModuleID == moduleid),
                MenuLevel1 = _uow.Menu.GetAll().Where(u => u.MenuLevel == 1 && u.ModuleID == moduleid),
                MenuLevel2 = _uow.Menu.GetAll().Where(u => u.MenuLevel == 2 && u.ModuleID == moduleid),
                MenuLevel3 = _uow.Menu.GetAll().Where(u => u.MenuLevel == 3 && u.ModuleID == moduleid)
            };

            return View(navMenuVM);
        }
    }

    [ViewComponent(Name = "breadcrumb")]
    public class BreadcrumbViewComponent : ViewComponent
    {
        private readonly IUnitOfWork _uow;
        public BreadcrumbViewComponent(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IViewComponentResult> InvokeAsync(int? moduleid)
        {
            if (moduleid == null) { moduleid = 0; };

            NavMenuVM navMenuVM = new()
            {
                MenuLevel1 = _uow.Menu.GetAll(u => u.MenuGroup == "Level1" && u.ModuleID == moduleid),
                MenuLevel2 = _uow.Menu.GetAll(u => u.MenuGroup == "Level2" && u.ModuleID == moduleid),
                MenuLevel3 = _uow.Menu.GetAll(u => u.MenuGroup == "Level3" && u.ModuleID == moduleid)
            };

            return View(navMenuVM);
        }
    }


}
