using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository
{
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
}
