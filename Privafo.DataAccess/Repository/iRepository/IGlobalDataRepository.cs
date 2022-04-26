using Privafo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository.IRepository
{
    public interface IIndustryRepository : IRepository<Industry>
    {
        void Update(Industry obj);
    }

    public interface IActiveStatusRepository : IRepository<ActiveStatus>
    {
        void Update(ActiveStatus obj);
    }
}
