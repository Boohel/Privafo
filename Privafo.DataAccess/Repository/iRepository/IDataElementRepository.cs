using Privafo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository.IRepository
{
    public interface IDteCategoryRepository : IRepository<DteCategory>
    {
        void Update(DteCategory obj);
    }
    public interface IDteSourceRepository : IRepository<DteSource>
    {
        void Update(DteSource obj);
    }
    public interface IDteTransferRepository : IRepository<DteTransfer>
    {
        void Update(DteTransfer obj);
    }
    public interface IDteVolumeRepository : IRepository<DteVolume>
    {
        void Update(DteVolume obj);
    }
    public interface IDataSubjectRepository : IRepository<DataSubject>
    {
        void Update(DataSubject obj);
    }
}
