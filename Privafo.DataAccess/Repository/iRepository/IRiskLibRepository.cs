﻿using Privafo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository.IRepository
{
    public interface IRiskLibRepository : IRepository<RiskLibrary>
    {
        void Update(RiskLibrary obj);
    }
}
