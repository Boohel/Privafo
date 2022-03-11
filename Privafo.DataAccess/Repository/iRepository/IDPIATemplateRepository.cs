﻿using Privafo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository.IRepository
{
    public interface IDPIATemplateRepository : IRepository<DPIATemplate>
    {
        void Update(DPIATemplate obj);
    }

    public interface IDPIAAssetRepository : IRepository<DPIAAsset>
    {
       // void Update(DPIAAsset obj);
    }


}
