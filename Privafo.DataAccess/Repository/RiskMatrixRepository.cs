using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository
{
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
}
