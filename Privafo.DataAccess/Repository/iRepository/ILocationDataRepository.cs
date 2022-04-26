using Privafo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository.IRepository
{
    public interface ICountryRepository : IRepository<Country>
    {
        void Update(Country obj);
    }

    public interface IProvinceRepository : IRepository<Province>
    {
        void Update(Province obj);
    }
    public interface ICityRepository : IRepository<City>
    {
        void Update(City obj);
    }
}
