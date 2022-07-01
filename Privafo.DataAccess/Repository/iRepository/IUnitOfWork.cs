using Privafo.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        //Navigation
        IModuleCtgRepository ModuleCtg { get; }
        IModuleRepository Module { get; }
        IMenuRepository Menu { get; }

        //Risk
        IRiskCtgRepository RiskCtg { get; }
        IRiskTypeRepository RiskType { get; }
        IRiskLibRepository RiskLibrary { get; }
        IRiskRegRepository RiskRegister { get; }
        IRiskMatrixRepository RiskMatrix { get; }
        IRiskImpactRepository RiskImpact { get; }
        IRiskProbRepository RiskProbability { get; }
        IRiskRangeScoreRepository RiskRangeScore { get; }
        IRiskThreatRepository RiskThreat { get; }
        IRiskVulnerRepository RiskVulnerability { get; }

        //DPIA
        IDPIATemplateRepository DPIATemplate { get; }
        IDPIAAssetRepository DPIAAsset { get; }

        //Vendor
        IVendorProductCtgRepository VendorProductCtg { get; }
        IVendorTypeRepository VendorType { get; }

        //Data Element
        IDataElementRepository DataElement { get; }  
        IDteCategoryRepository DteCategory { get; }
        IDteSourceRepository DteSource { get; }
        IDteTransferRepository DteTransfer { get; }
        IDteVolumeRepository DteVolume { get; }
        IDataSubjectRepository DataSubject { get; }

        //Control Management
        IControlCtgRepository ControlCtg { get; }
        IControlRegCtgRepository ControlRegCtg { get; }
        IControlSourceRepository ControlSource { get; }
        IOrgSecMeasureRepository OrgSecMeasure { get; }

        //Asset Management
        IAssetRepository Asset { get; }
        IAssetTypeRepository AssetType { get; }
        IAssetDisposalRepository AssetDisposal { get; }

        //General Data
        IIndustryRepository Industry { get; }
        IActiveStatusRepository ActiveStatus { get; }

        //General Address
        IAddressRepository Address { get; }
        ICountryRepository Country { get; }
        IProvinceRepository Province { get; }
        ICityRepository City { get; }

        //Organization
        IBranchRepository Branch { get; }
        IEntityRepository Entity { get; }
        IOrganizationRepository Organization { get; }

        //Identity
        IUserRepository User { get; }
        IRoleRepository Role { get; }

        //Data Privacy
        IPrivacyRequestRepository PrivacyRequest { get; }
        IPrivacyReqTypeRepository PrivacyReqType { get; }
        IPrivacySubjectRepository PrivacySubject { get; }
        IPrivacyReqExtendRepository PrivacyReqExtend { get; }

        void Save();
    }
}
