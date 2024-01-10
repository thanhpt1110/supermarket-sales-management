using SupermarketManagementApp.DTO;
using SupermarketManagementApp.Infrastructure;
using SupermarketManagementApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SupermarketManagementApp.BUS
{
    public class EmployeeBUS
    {
        private static EmployeeBUS instance;
        private readonly UnitOfWork unitOfWork;

        private EmployeeBUS()
        {
            unitOfWork = new UnitOfWork();
        }

        public static EmployeeBUS GetInstance()
        {
            if (instance == null)
            {
                instance = new EmployeeBUS();
            }
            return instance;
        }
        public async Task<Result<IEnumerable<Employee>>> GetAllEmployee()
        {
            Result<IEnumerable<Employee>> result = new Result<IEnumerable<Employee>>();
            try
            {
                result.Data = await unitOfWork.EmployeeRepositoryDAO.GetAll();
                result.IsSuccess = true;
                result.ErrorMessage = string.Empty;
            }
            catch (Exception ex)
            {
                result.Data = null;
                result.ErrorMessage = ex.Message;
                result.IsSuccess = false;
            }
            return result;
        }
        public async Task<Result<Employee>> AddEmployee(Employee employee)
        {
            Result<Employee> result = new Result<Employee>();

            if (employee == null || string.IsNullOrWhiteSpace(employee.IdCardNumber)
                                   || string.IsNullOrWhiteSpace(employee.PhoneNumber)
                                   || string.IsNullOrWhiteSpace(employee.Gender)
                                   || string.IsNullOrWhiteSpace(employee.EmployeeName)
                                   || employee.Birthday == null)
            {
                result.ErrorMessage = "Please provide all required information";
                result.IsSuccess = false;
            }
            else
            {
                try
                {
                    result.Data = await unitOfWork.EmployeeRepositoryDAO.Add(employee);
                    result.IsSuccess = true;
                }
                catch (Exception ex)
                {
                    result.ErrorMessage = ex.Message;
                    result.IsSuccess = false;
                }
            }

            return result;
        }
        public async Task<Result<IEnumerable<Employee>>> searchEmployeeByName(string name)
        {
            Result<IEnumerable<Employee>> result = new Result<IEnumerable<Employee>>();
            try
            {
                result.Data = await unitOfWork.EmployeeRepositoryDAO.Find(p=>p.EmployeeName.Contains(name));
                result.IsSuccess = true;
                result.ErrorMessage = string.Empty;
            }
            catch(Exception e) {
                result.ErrorMessage = e.Message;
                result.IsSuccess = false;
            }
            return result;
        }
        public async Task<Result<bool>> removeEmployeeByID(int id)
        {
            Result<bool> result = new Result<bool>();
            try
            {
                result.Data = await unitOfWork.EmployeeRepositoryDAO.RemoveByID(id);
                result.IsSuccess = true;
                result.ErrorMessage = string.Empty;
            }
            catch (Exception e)
            {
                result.ErrorMessage = e.Message;
                result.IsSuccess = false;
            }
            return result;
        }
        public async Task<Result<Employee>> findEmployeeByID(long id)
        {
            Result<Employee> result = new Result<Employee>();
            try
            {
                result.Data = await unitOfWork.EmployeeRepositoryDAO.FindByID(id);
                result.IsSuccess = true;
                result.ErrorMessage = string.Empty;
            }
            catch (Exception e)
            {
                result.ErrorMessage = e.Message;
                result.IsSuccess = false;
            }
            return result;
        } 
        public async Task<Result<Employee>> updateEmployee(Employee employee)
        {
            
            Result<Employee> result = new Result<Employee>();

            if (employee == null || string.IsNullOrWhiteSpace(employee.IdCardNumber)
                                   || string.IsNullOrWhiteSpace(employee.PhoneNumber)
                                   || string.IsNullOrWhiteSpace(employee.Gender)
                                   || string.IsNullOrWhiteSpace(employee.EmployeeName)
                                   || employee.Birthday == null)
            {
                result.ErrorMessage = "Please provide all required information";
                result.IsSuccess = false;
            }
            else
            {
                try
                {
                    result.Data = await unitOfWork.EmployeeRepositoryDAO.Update(employee);
                    result.IsSuccess = true; 
                    result.ErrorMessage = string.Empty;
                }
                catch(Exception e)
                {
                    result.ErrorMessage = e.Message;
                    result.IsSuccess = false;
                }
            }
            return result;
        }
    }
}
