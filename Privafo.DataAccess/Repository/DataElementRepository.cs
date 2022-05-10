using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository
{
    public class DataElementRepository : Repository<DataElement>, IDataElementRepository
    {
        private ApplicationDbContext _db;

        public DataElementRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(DataElement obj)
        {
            _db.data_elements.Update(obj);
        }
    }

    public class DteCategoryRepository : Repository<DteCategory>, IDteCategoryRepository
    {
        private ApplicationDbContext _db;

        public DteCategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(DteCategory obj)
        {
            _db.dte_ctg.Update(obj);
        }
    }

    public class DteSourceRepository : Repository<DteSource>, IDteSourceRepository
    {
        private ApplicationDbContext _db;

        public DteSourceRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(DteSource obj)
        {
            _db.dte_source.Update(obj);
        }
    }

    public class DteTransferRepository : Repository<DteTransfer>, IDteTransferRepository
    {
        private ApplicationDbContext _db;

        public DteTransferRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(DteTransfer obj)
        {
            _db.dte_transfer.Update(obj);
        }
    }
    public class DteVolumeRepository : Repository<DteVolume>, IDteVolumeRepository
    {
        private ApplicationDbContext _db;

        public DteVolumeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(DteVolume obj)
        {
            _db.dte_volume.Update(obj);
        }
    }
    public class DataSubjectRepository : Repository<DataSubject>, IDataSubjectRepository
    {
        private ApplicationDbContext _db;

        public DataSubjectRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(DataSubject obj)
        {
            _db.data_subject.Update(obj);
        }
    }
}
