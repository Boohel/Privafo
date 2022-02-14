﻿using Privafo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository.IRepository
{
    public interface IModuleCtgRepository : IRepository<ModuleCtg>
    {
        void Update(ModuleCtg obj);
    }
}
