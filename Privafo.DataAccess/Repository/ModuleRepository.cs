using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository
{
    public class ModuleRepository : Repository<Module>, IModuleRepository
    {
        private ApplicationDbContext _db;

        public ModuleRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Module obj)
        {
            //_db.modules.Update(obj);

            var objFromDb = _db.modules.FirstOrDefault(u => u.ID == obj.ID);

            if (objFromDb != null)
            {
                objFromDb.ModuleName = obj.ModuleName;
                objFromDb.Description = obj.Description;
                objFromDb.ModuleColor = obj.ModuleColor;
                objFromDb.ModuleSort = obj.ModuleSort;
                objFromDb.ModuleImageClass = obj.ModuleImageClass;
                objFromDb.ModuleCtgID = obj.ModuleCtgID;
            }
        }
    }
}
