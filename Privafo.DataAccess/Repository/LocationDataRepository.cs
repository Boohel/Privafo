using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        private ApplicationDbContext _db;

        public AddressRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Address obj)
        {
            _db.address.Update(obj);
        }
    }
    public class CountryRepository : Repository<Country>, ICountryRepository
    {
        private ApplicationDbContext _db;

        public CountryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Country obj)
        {
            _db.countries.Update(obj);
        }
    }
    public class ProvinceRepository : Repository<Province>, IProvinceRepository
    {
        private ApplicationDbContext _db;

        public ProvinceRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Province obj)
        {
            //var objFromDb = _db.provinces.FirstOrDefault(u => u.ID == obj.ID);

            //if (objFromDb != null)
            //{
            //    objFromDb.ProvinceCode = obj.ProvinceCode;
            //    objFromDb.ProvinceName = obj.ProvinceName;
            //    objFromDb.CountryID = obj.CountryID;
            //}
            _db.provinces.Update(obj);
        }
    }
    public class CityRepository : Repository<City>, ICityRepository
    {
        private ApplicationDbContext _db;

        public CityRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(City obj)
        {
            _db.cities.Update(obj);
        }
    }
}
