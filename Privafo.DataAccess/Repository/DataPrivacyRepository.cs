using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository
{
    public class PrivacyRequestRepository : Repository<PrivacyRequest>, IPrivacyRequestRepository
    {
        private ApplicationDbContext _db;

        public PrivacyRequestRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(PrivacyRequest obj)
        {
            _db.privacy_request.Update(obj);
        }
    }

    public class PrivacyReqTypeRepository : Repository<PrivacyReqType>, IPrivacyReqTypeRepository
    {
        private ApplicationDbContext _db;

        public PrivacyReqTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(PrivacyReqType obj)
        {
            _db.privacy_req_type.Update(obj);
        }
    }

    public class PrivacySubjectRepository : Repository<PrivacySubject>, IPrivacySubjectRepository
    {
        private ApplicationDbContext _db;

        public PrivacySubjectRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(PrivacySubject obj)
        {
            _db.privacy_subject.Update(obj);
        }
    }

    public class PrivacyReqExtendRepository : Repository<PrivacyReqExtend>, IPrivacyReqExtendRepository
    {
        private ApplicationDbContext _db;

        public PrivacyReqExtendRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(PrivacyReqExtend obj)
        {
            _db.privacy_req_extend.Update(obj);
        }
    }

}
