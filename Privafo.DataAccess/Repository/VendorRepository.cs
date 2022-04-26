using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository
{
    public class VendorProductCtgRepository : Repository<VendorProductCtg>, IVendorProductCtgRepository
    {
        private ApplicationDbContext _db;

        public VendorProductCtgRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(VendorProductCtg obj)
        {
            _db.vendor_product_ctg.Update(obj);
        }
    }
    public class VendorTypeRepository : Repository<VendorType>, IVendorTypeRepository
    {
        private ApplicationDbContext _db;

        public VendorTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(VendorType obj)
        {
            _db.vendor_type.Update(obj);
        }
    }

}
