using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository
{
    public class DPIATemplateRepository : Repository<DPIATemplate>, IDPIATemplateRepository
    {
        private ApplicationDbContext _db;

        public DPIATemplateRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(DPIATemplate obj)
        {
            //_db.modules.Update(obj);

            var objFromDb = _db.dpia_template.FirstOrDefault(u => u.ID == obj.ID);

            if (objFromDb != null)
            {
                objFromDb.TemplateName = obj.TemplateName;
                objFromDb.Description = obj.Description;
                objFromDb.Icon = obj.Icon;
                objFromDb.Welcome = obj.Welcome;
                objFromDb.QuestionJSON = obj.QuestionJSON;
            }
        }

    }

    public class DPIAAssetRepository : Repository<DPIAAsset>, IDPIAAssetRepository
    {
        private ApplicationDbContext _db;

        public DPIAAssetRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        

    }

}
