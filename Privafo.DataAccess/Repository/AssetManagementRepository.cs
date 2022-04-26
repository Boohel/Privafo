using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository
{
    public class AssetRepository : Repository<Asset>, IAssetRepository
    {
        private ApplicationDbContext _db;

        public AssetRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Asset obj)
        {
            _db.assets.Update(obj);
        }
    }

    public class AssetTypeRepository : Repository<AssetType>, IAssetTypeRepository
    {
        private ApplicationDbContext _db;

        public AssetTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(AssetType obj)
        {
            _db.asset_type.Update(obj);
        }
    }
    public class AssetDisposalRepository : Repository<AssetDisposal>, IAssetDisposalRepository
    {
        private ApplicationDbContext _db;

        public AssetDisposalRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(AssetDisposal obj)
        {
            _db.asset_disposal.Update(obj);
        }
    }
}
