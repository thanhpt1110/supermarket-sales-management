using SupermarketManagementApp.DAO;
using SupermarketManagementApp.ErrorHandle;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementApp.Infrastructure.Repository
{
    public class EmployeeRepository: GenericRepository<Employee>
    {
        public EmployeeRepository():base()
        { 

        }
        public EmployeeRepository(SupermarketContext context):base(context)
        {
        }
        public override async Task<Employee> FindByID(long id)
        {
            try
            {
                Employee employee = await base.FindByID(id);
                if (employee == null)
                {
                    throw new NotExistedObjectException("Employee not existed");
                }
                return employee;
            }
            catch
            {
                throw;
            }
        }   
        public override async Task<IEnumerable<Employee>> GetAll()
        {
            try
            {
                return await base.GetAll();
            }
            catch {
                throw;
            }
        }
        public override async Task<Employee> Update(Employee entity)
        {
            try
            {
                if(await context.Employees.FindAsync(entity.EmployeeID)!=null) {
                    throw new NotExistedObjectException("Employee is not existeđ");
                }
                return await base.Update(entity);
            }
            catch (DbUpdateException ex)
            {
                // Check if the exception is due to a unique constraint violation
                if (ExistedObjectException.IsUniqueConstraintViolation(ex))
                {
                    // Handle the unique constraint violation
                    throw new ExistedObjectException("This phone number or ID card is already existed");
                }
                else
                {
                    throw;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public override async Task<Employee> Add(Employee entity)
        {
            try
            {
                var employeePhone = await context.Employees.Where(p => p.PhoneNumber == entity.PhoneNumber).SingleOrDefaultAsync();
                var employeeIDCard = await context.Employees.Where(p => p.IdCardNumber == entity.IdCardNumber).SingleOrDefaultAsync();

                if (employeePhone != null)
                {
                    throw new ExistedObjectException("Employee with that phone number already existed");
                }
                if (employeeIDCard != null)
                {
                    throw new ExistedObjectException("Employee with that ID card number already existed");
                }
                return await base.Add(entity);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public override async Task<Boolean> RemoveByID(long employeeID)
        {
            try
            {
                var employee = await context.Employees.FindAsync(employeeID);
                if (employee == null)
                    throw new NotExistedObjectException("Employee is not existed");
                if(employee.Accounts.Count > 0)
                {
                    throw new ObjectDependException("Can not remove employee");
                }
                return await base.RemoveByID(employeeID);
            }
            catch {
                throw;
            }
        }
        public override Task<IEnumerable<Employee>> Find(Expression<Func<Employee, bool>> predicate)
        {
            try
            {
                return base.Find(predicate);
            }
            catch
            {
                throw;
            }
        }

    }
}
