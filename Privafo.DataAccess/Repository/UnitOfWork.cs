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

            //Navigation
            ModuleCtg = new ModuleCtgRepository(_db);
            Module = new ModuleRepository(_db);
            Menu = new MenuRepository(_db);

            //Risk
            RiskType = new RiskTypeRepository(_db);
            RiskCtg = new RiskCtgRepository(_db);
            RiskLibrary = new RiskLibRepository(_db);
            RiskRegister = new RiskRegRepository(_db);
            RiskMatrix = new RiskMatrixRepository(_db);
            RiskImpact = new RiskImpactRepository(_db);
            RiskProbability = new RiskProbRepository(_db);
            RiskThreat = new RiskThreatRepository(_db);
            RiskVulnerability = new RiskVulnerRepository(_db);

            //DPIA
            DPIATemplate = new DPIATemplateRepository(_db);
            DPIAAsset = new DPIAAssetRepository(_db);
        }

        //Navigation
        public IModuleCtgRepository ModuleCtg { get; private set; }
        public IModuleRepository Module { get; private set; }
        public IMenuRepository Menu { get; private set; }

        //Risk
        public IRiskTypeRepository RiskType { get; private set; }
        public IRiskCtgRepository RiskCtg { get; private set; }
        public IRiskLibRepository RiskLibrary { get; private set; }
        public IRiskRegRepository RiskRegister { get; private set; }
        public IRiskMatrixRepository RiskMatrix { get; private set; }
        public IRiskImpactRepository RiskImpact { get; private set; }
        public IRiskProbRepository RiskProbability { get; private set; }
        public IRiskThreatRepository RiskThreat { get; private set; }
        public IRiskVulnerRepository RiskVulnerability { get; private set; }

        //DPIA
        public IDPIATemplateRepository DPIATemplate { get; private set; }
        public IDPIAAssetRepository DPIAAsset { get; private set; }
        public void Save()
        {
           _db.SaveChanges();
        }
    } 
}
