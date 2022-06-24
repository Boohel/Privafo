using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository
{
    public class BranchRepository : Repository<Branch>, IBranchRepository
    {
        private ApplicationDbContext _db;

        public BranchRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Branch obj)
        {
            _db.branches.Update(obj);
        }
    }
    public class EntityRepository : Repository<Entity>, IEntityRepository
    {
        private ApplicationDbContext _db;

        public EntityRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Entity obj)
        {
            _db.entities.Update(obj);
        }
    }
    public class OrganizationRepository : Repository<Organization>, IOrganizationRepository
    {
        private ApplicationDbContext _db;

        public OrganizationRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Organization obj)
        {
            _db.organization.Update(obj);
        }
    }

}
