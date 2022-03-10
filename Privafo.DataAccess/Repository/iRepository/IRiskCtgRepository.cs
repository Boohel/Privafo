using Privafo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository.IRepository
{
    public interface IRiskCtgRepository : IRepository<RiskCtg>
    {
        void Update(RiskCtg obj);
    }
}
