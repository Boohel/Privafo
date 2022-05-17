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
            RiskRangeScore = new RiskRangeScoreRepository(_db);
            RiskThreat = new RiskThreatRepository(_db);
            RiskVulnerability = new RiskVulnerRepository(_db);

            //DPIA
            DPIATemplate = new DPIATemplateRepository(_db);
            DPIAAsset = new DPIAAssetRepository(_db);

            //Vendor
            VendorProductCtg = new VendorProductCtgRepository(_db);
            VendorType = new VendorTypeRepository(_db);

            //Data Element
            DataElement = new DataElementRepository(_db);
            DteCategory = new DteCategoryRepository(_db);
            DteSource = new DteSourceRepository(_db);
            DteTransfer = new DteTransferRepository(_db);
            DteVolume = new DteVolumeRepository(_db);
            DataSubject = new DataSubjectRepository(_db);

            //Control Management 
            ControlCtg = new ControlCtgRepository(_db);
            ControlRegCtg = new ControlRegCtgRepository(_db);
            ControlSource = new ControlSourceRepository(_db);
            OrgSecMeasure = new OrgSecMeasureRepository(_db);

            //Asset Management
            Asset = new AssetRepository(_db);
            AssetType = new AssetTypeRepository(_db);
            AssetDisposal = new AssetDisposalRepository(_db);

            //General Data
            Industry = new IndustryRepository(_db);
            ActiveStatus = new ActiveStatusRepository(_db);

            //General Address
            Country = new CountryRepository(_db);
            Province = new ProvinceRepository(_db);
            City = new CityRepository(_db);

            //Organization
            Branch = new BranchRepository(_db);
            Entity = new EntityRepository(_db);
            Organization = new OrganizationRepository(_db);

            //Identity
            User = new UserRepository(_db);
            Role = new RoleRepository(_db);

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
        public IRiskRangeScoreRepository RiskRangeScore { get; private set; }
        public IRiskThreatRepository RiskThreat { get; private set; }
        public IRiskVulnerRepository RiskVulnerability { get; private set; }

        //DPIA
        public IDPIATemplateRepository DPIATemplate { get; private set; }
        public IDPIAAssetRepository DPIAAsset { get; private set; }

        //Vendor
        public IVendorProductCtgRepository VendorProductCtg { get; private set; }
        public IVendorTypeRepository VendorType { get; private set; }

        //Data Element
        public IDataElementRepository DataElement { get; private set; }
        public IDteCategoryRepository DteCategory { get; private set; }
        public IDteSourceRepository DteSource { get; private set; }
        public IDteTransferRepository DteTransfer { get; private set; }
        public IDteVolumeRepository DteVolume { get; private set; }
        public IDataSubjectRepository DataSubject { get; private set; }

        //Control Management 
        public IControlCtgRepository ControlCtg { get; private set; }
        public IControlRegCtgRepository ControlRegCtg { get; private set; }
        public IControlSourceRepository ControlSource { get; private set; }
        public IOrgSecMeasureRepository OrgSecMeasure { get; private set; }

        //Asset Management
        public IAssetRepository Asset { get; private set; }
        public IAssetTypeRepository AssetType { get; private set; }
        public IAssetDisposalRepository AssetDisposal { get; private set; }

        //General Data
        public IIndustryRepository Industry { get; private set; }
        public IActiveStatusRepository ActiveStatus { get; private set; }

        //General Address
        public ICountryRepository Country { get; private set; }
        public IProvinceRepository Province { get; private set; }
        public ICityRepository City { get; private set; }

        //Organization
        public IBranchRepository Branch { get; private set; }
        public IEntityRepository Entity { get; private set; }
        public IOrganizationRepository Organization { get; private set; }

        //Organization
        public IUserRepository User { get; private set; }
        public IRoleRepository Role { get; private set; }

        public void Save()
        {
           _db.SaveChanges();
        }
    } 
}
