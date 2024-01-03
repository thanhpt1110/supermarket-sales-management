using SupermarketManagementApp.DAO;
using SupermarketManagementApp.ErrorHandle;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
                var employee = await context.Employees.FindAsync(entity.EmployeeID);
                if (employee == null)
                {
                    throw new NotExistedObjectException("Employee is not existed");
                }
                employee.EmployeeName = (entity.EmployeeName != null || entity.EmployeeName != "") ? entity.EmployeeName : employee.EmployeeName;
                employee.Gender = (entity.Gender != null || entity.Gender != "") ? entity.Gender : employee.Gender;
                employee.Birthday = (entity.Birthday != null) ? entity.Birthday : employee.Birthday;
                employee.IdCardNumber = (entity.IdCardNumber != null || entity.IdCardNumber != "") ? entity.IdCardNumber : employee.IdCardNumber;
                employee.PhoneNumber = (entity.PhoneNumber != null || entity.PhoneNumber != "") ? entity.PhoneNumber : employee.PhoneNumber;
                return await base.Update(employee);
            }
            catch(Exception ex)
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
                    throw new ExistedObjectException("Employee with that phone ID number already existed");
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
