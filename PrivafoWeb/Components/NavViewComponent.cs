using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PrivafoWeb.Components
{
    [ViewComponent(Name = "module")]
    public class ModuleViewComponent : ViewComponent
    {
        //private privafo.Data.PrivafoContext _databaseContext;
        //public headerComponent(privafo.Data.PrivafoContext databaseContext)
        //{
        //    _databaseContext = databaseContext;
        //}
        //public async Task<IViewComponentResult> InvokeAsync()
        //{
        //    return View(await _databaseContext.module.ToListAsync());
        //}
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }

    [ViewComponent(Name = "leftmenu")]
    public class LeftMenuViewComponent : ViewComponent
    {

        //private privafo.Data.PrivafoContext _databaseContext;
        //public leftmenuComponent(privafo.Data.PrivafoContext databaseContext)
        //{
        //    _databaseContext = databaseContext;
        //}

        //public async Task<IViewComponentResult> InvokeAsync(string? moduleid)
        //{
        //    if (moduleid == null)
        //    { moduleid = "0"; };
        //    var listofMenu = (from menu in _databaseContext.menu
        //                      where menu.ModuleID == Int32.Parse(moduleid)
        //                      select menu).ToListAsync();
        //    return View(await listofMenu);
        //}

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
