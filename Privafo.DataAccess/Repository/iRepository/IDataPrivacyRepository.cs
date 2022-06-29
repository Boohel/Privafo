using Privafo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository.IRepository
{
    public interface IPrivacyRequestRepository : IRepository<PrivacyRequest>
    {
        void Update(PrivacyRequest obj);
    }

    public interface IPrivacyReqTypeRepository : IRepository<PrivacyReqType>
    {
        void Update(PrivacyReqType obj);
    }

    public interface IPrivacySubjectRepository : IRepository<PrivacySubject>
    {
        void Update(PrivacySubject obj);
    }

    public interface IPrivacyReqExtendRepository : IRepository<PrivacyReqExtend>
    {
        void Update(PrivacyReqExtend obj);
    }
}
