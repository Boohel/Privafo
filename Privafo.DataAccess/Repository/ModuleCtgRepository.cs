using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository
{
    public class ModuleCtgRepository : Repository<ModuleCtg>, IModuleCtgRepository
    {
        private ApplicationDbContext _db;

        public ModuleCtgRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ModuleCtg obj)
        {
            _db.module_ctg.Update(obj);
        }
    }
}
