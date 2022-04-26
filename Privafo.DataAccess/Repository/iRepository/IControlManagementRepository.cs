using Privafo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository.IRepository
{
    public interface IControlCtgRepository : IRepository<ControlCtg>
    {
        void Update(ControlCtg obj);
    }
    public interface IControlRegCtgRepository : IRepository<ControlRegCtg>
    {
        void Update(ControlRegCtg obj);
    }
    public interface IControlSourceRepository : IRepository<ControlSource>
    {
        void Update(ControlSource obj);
    }
    public interface IOrgSecMeasureRepository : IRepository<OrgSecMeasure>
    {
        void Update(OrgSecMeasure obj);
    }

}
