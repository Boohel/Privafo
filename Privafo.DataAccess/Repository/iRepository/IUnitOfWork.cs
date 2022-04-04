﻿using Privafo.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IModuleCtgRepository ModuleCtg { get; }
        IModuleRepository Module { get; }
        IMenuRepository Menu { get; }
        IRiskCtgRepository RiskCtg { get; }
        IRiskTypeRepository RiskType { get; }
        IRiskRegRepository RiskRegister { get; }
        IRiskMatrixRepository RiskMatrix { get; }
        IDPIATemplateRepository DPIATemplate { get; }
        IDPIAAssetRepository DPIAAsset { get; }

        void Save();
    }
}
