using SupermarketManagementApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementApp.DAO
{
    public interface IRepositoryDAO<T>
    {
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> AddOrUpdate(T entity);  
        Task<T> FindByID(long id);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);
        Task<Boolean> RemoveByID(long id);
        Task UpdateManyAsync(IEnumerable<T> entities);
        void SaveChanges();
    }
}
