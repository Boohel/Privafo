using Privafo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository.IRepository
{
    public interface IRiskLibRepository : IRepository<RiskLibrary>
    {
        void Update(RiskLibrary obj);
    }

    public interface IRiskRegRepository : IRepository<RiskRegister>
    {
        void Update(RiskRegister obj);
    }

    public interface IRiskCtgRepository : IRepository<RiskCtg>
    {
        void Update(RiskCtg obj);
    }

    public interface IRiskTypeRepository : IRepository<RiskType>
    {
        void Update(RiskType obj);
    }

    public interface IRiskImpactRepository : IRepository<RiskImpact>
    {
        void Update(RiskImpact obj);
    }

    public interface IRiskProbRepository : IRepository<RiskProbability>
    {
        void Update(RiskProbability obj);
    }

    public interface IRiskMatrixRepository : IRepository<RiskMatrixScore>
    {
        void Update(RiskMatrixScore obj);
    }

    public interface IRiskRangeScoreRepository : IRepository<RiskRangeScore>
    {
        void Update(RiskRangeScore obj);
    }

    public interface IRiskThreatRepository : IRepository<RiskThreat>
    {
        void Update(RiskThreat obj);
    }

    public interface IRiskVulnerRepository : IRepository<RiskVulnerability>
    {
        void Update(RiskVulnerability obj);
    }
}
