using SupermarketManagementApp.DTO;
using SupermarketManagementApp.ErrorHandle;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementApp.DAO
{
    public abstract class GenericRepositoryDAO<T> : IRepositoryDAO<T> where T : class
    {
        protected SupermarketContext context;
        public GenericRepositoryDAO()
        {
            this.context = new SupermarketContext();
        }
        public GenericRepositoryDAO(SupermarketContext context)
        {
            this.context = context;
        }

        public virtual async Task<T> Add(T entity)
        {
            try
            {
                var entry = context.Set<T>().Add(entity);
                await context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public virtual async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return await context.Set<T>().Where(predicate).ToListAsync();
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            try
            {
                return await context.Set<T>().ToListAsync();
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        public virtual async Task<T> Update(T entity)
        {
            try
            {
                context.Entry(entity).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public virtual async Task UpdateManyAsync(IEnumerable<T> entities)
        {
            try
            {
                foreach (var entity in entities)
                {
                    context.Entry(entity).State = EntityState.Modified;
                }
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public virtual async Task<T> FindByID(long id)
        {
            try
            {
                return await context.Set<T>().FindAsync(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public virtual async Task<Boolean> RemoveByID(long id)
        {
            try
            {
                var entityToRemove = await context.Set<T>().FindAsync(id);

                if (entityToRemove == null)
                    throw new NotExistedObjectException("Not existed object"); // Không tìm thấy đối tượng để xóa

                context.Set<T>().Remove(entityToRemove);
                await context.SaveChangesAsync();
                return true;
            }
            catch { throw; }
        }
        public virtual async Task<T> AddOrUpdate(T entity)
        {
            context.Set<T>().AddOrUpdate(entity);
            await context.SaveChangesAsync();
            return entity;
        }
        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
