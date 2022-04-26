using Privafo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository.IRepository
{
    public interface IVendorProductCtgRepository : IRepository<VendorProductCtg>
    {
        void Update(VendorProductCtg obj);
    }

    public interface IVendorTypeRepository : IRepository<VendorType>
    {
        void Update(VendorType obj);
    }
}
