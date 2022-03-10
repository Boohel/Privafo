using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository
{
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
}
