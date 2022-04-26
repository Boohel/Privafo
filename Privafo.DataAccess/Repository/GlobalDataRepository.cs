using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository
{
    public class IndustryRepository : Repository<Industry>, IIndustryRepository
    {
        private ApplicationDbContext _db;

        public IndustryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Industry obj)
        {
            _db.industries.Update(obj);
        }
    }
    public class ActiveStatusRepository : Repository<ActiveStatus>, IActiveStatusRepository
    {
        private ApplicationDbContext _db;

        public ActiveStatusRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ActiveStatus obj)
        {
            _db.status.Update(obj);
        }
    }

}
