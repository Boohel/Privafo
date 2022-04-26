using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository
{
    public class ControlCtgRepository : Repository<ControlCtg>, IControlCtgRepository
    {
        private ApplicationDbContext _db;

        public ControlCtgRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ControlCtg obj)
        {
            _db.control_ctg.Update(obj);
        }
    }

    public class ControlRegCtgRepository : Repository<ControlRegCtg>, IControlRegCtgRepository
    {
        private ApplicationDbContext _db;

        public ControlRegCtgRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ControlRegCtg obj)
        {
            _db.control_reg_ctg.Update(obj);
        }
    }
    public class ControlSourceRepository : Repository<ControlSource>, IControlSourceRepository
    {
        private ApplicationDbContext _db;

        public ControlSourceRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ControlSource obj)
        {
            _db.control_source.Update(obj);
        }
    }
    public class OrgSecMeasureRepository : Repository<OrgSecMeasure>, IOrgSecMeasureRepository
    {
        private ApplicationDbContext _db;

        public OrgSecMeasureRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(OrgSecMeasure obj)
        {
            _db.org_sec_measure.Update(obj);
        }
    }
}
