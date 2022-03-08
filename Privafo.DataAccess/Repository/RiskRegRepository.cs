using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository
{
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
}
