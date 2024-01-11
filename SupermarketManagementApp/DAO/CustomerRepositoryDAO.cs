using SupermarketManagementApp.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarketManagementApp.ErrorHandle;
using System.Linq.Expressions;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;

namespace SupermarketManagementApp.DAO
{
    public class CustomerRepositoryDAO: GenericRepositoryDAO<Customer>
    {
        public CustomerRepositoryDAO():base() { }
        public CustomerRepositoryDAO(SupermarketContext context) : base(context) { }
        public override async Task<Customer> Add(Customer entity)
        {
            try
            {
                var customerPhoneNum = await context.Customers.SingleOrDefaultAsync<Customer>(p => p.PhoneNumber == entity.PhoneNumber);
                if (customerPhoneNum != null)
                {
                    throw new ExistedObjectException("Customer with this phone number already existed");
                }
                return await base.Add(entity);
            }
            catch
            {
                throw;
            }
        }
        public override async Task<IEnumerable<Customer>> Find(Expression<Func<Customer, bool>> predicate)
        {
            try
            {
                return await base.Find(predicate);
            }
            catch
            {
                throw;
            }
        }
        public override async Task<Customer> FindByID(long id)
        {
            try
            {
                var customer = await base.FindByID(id);
                if (customer == null)
                {
                    throw new NotExistedObjectException("Customer is not existed");
                }
                return customer;
            }
            catch
            {
                throw;
            }
        }
        public override async Task<IEnumerable<Customer>> GetAll()
        {
            try
            {
                return await base.GetAll();

            }
            catch
            {
                throw;
            }
        }
        public override async Task<bool> RemoveByID(long id)
        {
            try
            {
                var customer = await context.Customers.FindAsync(id);
                if (customer == null)
                {
                    throw new NotExistedObjectException("Customer is not existed");
                }
                if (customer.CustomerInvoices.Count > 0)
                {
                    throw new ObjectDependException("Couldn't remove this customer");
                }
                return await base.RemoveByID(id);
            }
            catch { throw; }
        }
        public override async Task<Customer> Update(Customer entity)
        {
            try
            {
                var customer = await context.Customers.FindAsync(entity.CustomerID);
                if (customer == null)
                {
                    throw new NotExistedObjectException("Customer is not existed");
                }
                customer.PhoneNumber = entity.PhoneNumber;
                customer.Birthday = entity.Birthday;
                customer.Gender = entity.Gender;
                customer.CustomerName = entity.CustomerName;
                context.Customers.AddOrUpdate(customer);
                await context.SaveChangesAsync();
                return customer;
            }
            catch (DbUpdateException ex)
            {
                // Check if the exception is due to a unique constraint violation
                if (ExistedObjectException.IsUniqueConstraintViolation(ex))
                {
                    // Handle the unique constraint violation
                    throw new ExistedObjectException("This phone number is already existed");
                }
                else
                {
                    throw;
                }
            }
            catch { throw; }
        }
    }
}
