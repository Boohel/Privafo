using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository
{
    public class RiskLibRepository : Repository<RiskLibrary>, IRiskLibRepository
    {
        private ApplicationDbContext _db;

        public RiskLibRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(RiskLibrary obj)
        {
            _db.risk_library.Update(obj);
        }
    }

    public class RiskRegRepository : Repository<RiskRegister>, IRiskRegRepository
    {
        private ApplicationDbContext _db;

        public RiskRegRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(RiskRegister obj)
        {
            _db.risk_register.Update(obj);
        }
    }

    public class RiskCtgRepository : Repository<RiskCtg>, IRiskCtgRepository
    {
        private ApplicationDbContext _db;

        public RiskCtgRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(RiskCtg obj)
        {
            _db.risk_ctg.Update(obj);
        }
    }

    public class RiskTypeRepository : Repository<RiskType>, IRiskTypeRepository
    {
        private ApplicationDbContext _db;

        public RiskTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(RiskType obj)
        {
            _db.risk_type.Update(obj);
        }
    }

    public class RiskImpactRepository : Repository<RiskImpact>, IRiskImpactRepository
    {
        private ApplicationDbContext _db;

        public RiskImpactRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(RiskImpact obj)
        {
            _db.risk_impact.Update(obj);
        }
    }

    public class RiskProbRepository : Repository<RiskProbability>, IRiskProbRepository
    {
        private ApplicationDbContext _db;

        public RiskProbRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(RiskProbability obj)
        {
            _db.risk_probability.Update(obj);
        }
    }

    public class RiskMatrixRepository : Repository<RiskMatrixScore>, IRiskMatrixRepository
    {
        private ApplicationDbContext _db;

        public RiskMatrixRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(RiskMatrixScore obj)
        {
            _db.risk_matrix_score.Update(obj);
        }
    }

    public class RiskRangeScoreRepository : Repository<RiskRangeScore>, IRiskRangeScoreRepository
    {
        private ApplicationDbContext _db;

        public RiskRangeScoreRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(RiskRangeScore obj)
        {
            _db.risk_range_score.Update(obj);
        }
    }

    public class RiskThreatRepository : Repository<RiskThreat>, IRiskThreatRepository
    {
        private ApplicationDbContext _db;

        public RiskThreatRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(RiskThreat obj)
        {
            _db.risk_threats.Update(obj);
        }
    }

    public class RiskVulnerRepository : Repository<RiskVulnerability>, IRiskVulnerRepository
    {
        private ApplicationDbContext _db;

        public RiskVulnerRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(RiskVulnerability obj)
        {
            _db.risk_vulneries.Update(obj);
        }
    }

}
