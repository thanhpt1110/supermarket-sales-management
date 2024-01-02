using SupermarketManagementApp.DAO;
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
        public override async Task<Employee> FindByID(int id)
        {
            Employee employee = await base.FindByID(id);
            return employee;
        }
        public override async Task<IEnumerable<Employee>> GetAll()
        {
            return await base.GetAll();
        }
        public override async Task<Employee> Update(Employee entity)
        {
            var employee = await context.Employees.FindAsync(entity.EmployeeID);
            if (employee == null)
            {
                return null;
            }
            employee.EmployeeName = (entity.EmployeeName != null || entity.EmployeeName != "") ? entity.EmployeeName : employee.EmployeeName;
            employee.Gender = (entity.Gender != null || entity.Gender != "") ? entity.Gender: employee.Gender;
            employee.Birthday = (entity.Birthday != null) ? entity.Birthday : employee.Birthday;
            employee.IdCardNumber = (entity.IdCardNumber != null || entity.IdCardNumber != "") ? entity.IdCardNumber : employee.IdCardNumber;
            employee.PhoneNumber = (entity.PhoneNumber != null || entity.PhoneNumber != "") ? entity.PhoneNumber : employee.PhoneNumber;
            return await base.Update(employee);
        }
        public override async Task<Employee> Add(Employee entity)
        {
            var employee = await context.Employees.Where(p=>p.IdCardNumber == entity.IdCardNumber || p.PhoneNumber == entity.PhoneNumber).SingleOrDefaultAsync();
            return await base.Add(entity);
        }
        public override async Task<Boolean> RemoveByID(int EmployeeID)
        {
            var employee = await context.Employees.SingleOrDefaultAsync<Employee>(p=>p.EmployeeID == EmployeeID);
            if (employee == null)
                return false;
            return await base.RemoveByID(EmployeeID);
        }
    }
}
