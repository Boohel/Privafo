using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository
{
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
}
