using SupermarketManagementApp.ErrorHandle;
using SupermarketManagementApp.Infrastructure;
using SupermarketManagementApp.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace SupermarketManagementApp.BUS
{
    public class AccountBUS
    {
        private static AccountBUS instance;
        private readonly UnitOfWork unitOfWork;

        private AccountBUS()
        {
            unitOfWork = new UnitOfWork();
        }

        public static AccountBUS GetInstance()
        {
            if (instance == null)
            {
                instance = new AccountBUS();
            }
            return instance;
        }
        public async Task<Result<DTO.Account>> getAccountByID(int id)
        {
            Result<DTO.Account> result = new Result<DTO.Account> ();
            try
            {
                result.Data = await unitOfWork.AccountRepositoryDAO.FindByID(id);
                result.IsSuccess = true;
                result.ErrorMessage = null;
            }
            catch (Exception ex)
            {
                result.Data = null;
                result.ErrorMessage = ex.Message;
                result.IsSuccess = false;
            }
            return result;
        }
        public async Task<Result<IEnumerable<DTO.Account>>> findAccountByUsername(string userName)
        {
            Result<IEnumerable<DTO.Account>> result = new Result<IEnumerable<DTO.Account>>();
            try
            {
                result.Data = await unitOfWork.AccountRepositoryDAO.Find(account => account.Username.Contains(userName));
                result.IsSuccess = true;
                result.ErrorMessage = null;
            }
            catch (Exception ex)
            {
                result.Data = null;
                result.ErrorMessage = ex.Message;
                result.IsSuccess = false;
            }
            return result;
        }
        public async Task<Result<IEnumerable<DTO.Account>>> getAllAccount()
        {
            Result<IEnumerable<DTO.Account>> result = new Result<IEnumerable<DTO.Account>>();
            try
            {
                result.Data = await unitOfWork.AccountRepositoryDAO.GetAll();
                result.IsSuccess = true;
                result.ErrorMessage = null;
            }
            catch (Exception ex)
            {
                result.Data = null;
                result.ErrorMessage = ex.Message;
                result.IsSuccess = false;
            }
            return result;
        }
        public async Task<Result<DTO.Account>> createNewAccount(DTO.Account account)
        {
            Result<DTO.Account> result = new Result<DTO.Account>();
            if (string.IsNullOrEmpty(account.Username) || string.IsNullOrEmpty(account.Password) || account.EmployeeID == 0
                || string.IsNullOrEmpty(account.Role))
            {
                result.Data = null;
                result.IsSuccess = false;
                result.ErrorMessage = "Please provide all required information!";
            }
            else
            {
                try
                {
                    result.Data = await unitOfWork.AccountRepositoryDAO.Add(account);
                    result.IsSuccess = true;
                    result.ErrorMessage = null;
                    await unitOfWork.SaveChanges();
                    return result;
                }
                catch (Exception e)
                {
                    // Xử lý các exception khác nếu cần
                    result.ErrorMessage = e.Message;
                    result.IsSuccess = false;
                    result.Data = null;
                }
            }
            return result;
        }
        public async Task<Result<DTO.Account>> updateAccount(DTO.Account account)
        {
            Result<DTO.Account> result = new Result<DTO.Account>();
            if (string.IsNullOrEmpty(account.Username) || string.IsNullOrEmpty(account.Password) || account.EmployeeID == 0)
            {
                result.Data = null;
                result.IsSuccess = false;
                result.ErrorMessage = "Please enter all information";
            }
            else
            {
                try
                {
                    result.Data = await unitOfWork.AccountRepositoryDAO.Update(account);
                    result.IsSuccess = true;
                    result.ErrorMessage = null;
                    await unitOfWork.SaveChanges();
                    return result;
                    
                }
                catch (Exception e)
                {
                    // Xử lý các exception khác nếu cần
                    result.ErrorMessage = e.Message;
                    result.IsSuccess = false;
                    result.Data = null;
                }
            }
            return result;
        }
        public async Task<Result<bool>> deleteAccount(int accountId)
        {
            Result<bool> result = new Result<bool>();
            try
            {
                result.Data = await unitOfWork.AccountRepositoryDAO.RemoveByID(accountId);
                result.IsSuccess = true;
                result.ErrorMessage = null;
                await unitOfWork.SaveChanges();
            }
            catch (Exception e)
            {
                // Xử lý các exception khác nếu cần
                result.ErrorMessage = e.Message;
                result.IsSuccess = false;
                result.Data = false;
            }
            return result;
        }
    }

}
