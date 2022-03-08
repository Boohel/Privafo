using Privafo.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            ModuleCtg = new ModuleCtgRepository(_db);
            Module = new ModuleRepository(_db);
            Menu = new MenuRepository(_db);
            RiskType = new RiskTypeRepository(_db);
            RiskRegister = new RiskRegRepository(_db);
            RiskMatrix = new RiskMatrixRepository(_db);
        }
        public IModuleCtgRepository ModuleCtg { get; private set; }
        public IModuleRepository Module { get; private set; }
        public IMenuRepository Menu { get; private set; }
        public IRiskTypeRepository RiskType { get; private set; }
        public IRiskRegRepository RiskRegister { get; private set; }
        public IRiskMatrixRepository RiskMatrix { get; private set; }

        public void Save()
        {
           _db.SaveChanges();
        }
    } 
}
