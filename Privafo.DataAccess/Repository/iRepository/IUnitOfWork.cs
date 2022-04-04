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
        IRiskThreatRepository RiskThreat { get; }
        IRiskVulnerRepository RiskVulnerability { get; }


        //DPIA
        IDPIATemplateRepository DPIATemplate { get; }
        IDPIAAssetRepository DPIAAsset { get; }

        void Save();
    }
}
