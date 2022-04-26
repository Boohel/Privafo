using Privafo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository.IRepository
{
    public interface IAssetRepository : IRepository<Asset>
    {
        void Update(Asset obj);
    }
    public interface IAssetTypeRepository : IRepository<AssetType>
    {
        void Update(AssetType obj);
    }
    public interface IAssetDisposalRepository : IRepository<AssetDisposal>
    {
        void Update(AssetDisposal obj);
    }

}
