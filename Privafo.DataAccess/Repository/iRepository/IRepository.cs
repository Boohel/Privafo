using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T GetFirstOrDefault(Expression<Func<T, bool>> filter, string? includeProperties = null);
        IEnumerable<T> GetAll(string? includeProperties = null);
        IEnumerable<T> GetAllFilter(Expression<Func<T, bool>>? filter, string? includeProperties = null);
        IEnumerable<T> GetAllCustom();
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
    }
}
