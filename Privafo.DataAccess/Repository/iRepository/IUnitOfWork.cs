using Privafo.DataAccess.Repository.IRepository;
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

        void Save();
    }
}
