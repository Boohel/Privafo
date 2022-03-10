using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository
{
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
}
