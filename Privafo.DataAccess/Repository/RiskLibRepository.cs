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
}
