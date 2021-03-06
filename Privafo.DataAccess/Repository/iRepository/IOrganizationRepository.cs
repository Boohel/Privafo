using Privafo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository.IRepository
{
    public interface IBranchRepository : IRepository<Branch>
    {
        void Update(Branch obj);
    }

    public interface IEntityRepository : IRepository<Entity>
    {
        void Update(Entity obj);
    }

    public interface IOrganizationRepository : IRepository<Organization>
    {
        void Update(Organization obj);
    }
}
