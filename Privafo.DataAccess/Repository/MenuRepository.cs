using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository
{
    public class MenuRepository : Repository<Menu>, IMenuRepository
    {
        private ApplicationDbContext _db;

        public MenuRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Menu obj)
        {
            //_db.modules.Update(obj);

            var objFromDb = _db.menus.FirstOrDefault(u => u.ID == obj.ID);

            if (objFromDb != null)
            {
                objFromDb.MenuName = obj.MenuName;
                objFromDb.Description = obj.Description;
                objFromDb.ControllerName = obj.ControllerName;
                objFromDb.ActionName = obj.ActionName;
                objFromDb.MenuSort = obj.MenuSort;
                objFromDb.MenuImageClass = obj.MenuImageClass;
                objFromDb.MenuGroup = obj.MenuGroup;
                objFromDb.MenuKey = obj.MenuKey;
                objFromDb.ParentID = obj.ParentID;
                objFromDb.ModuleID = obj.ModuleID;
            }
        }
    }
}
