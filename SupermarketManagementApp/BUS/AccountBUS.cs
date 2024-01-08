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
        public async Task<Result<DAO.Account>> getAccountByID(int id)
        {
            Result<DAO.Account> result = new Result<DAO.Account> ();
            try
            {
                result.Data = await unitOfWork.AccountRepository.FindByID(id);
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
        public async Task<Result<IEnumerable<DAO.Account>>> findAccountByUsername(string userName)
        {
            Result<IEnumerable<DAO.Account>> result = new Result<IEnumerable<DAO.Account>>();
            try
            {
                result.Data = await unitOfWork.AccountRepository.Find(account => account.Username.Contains(userName));
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
        public async Task<Result<IEnumerable<DAO.Account>>> getAllAccount()
        {
            Result<IEnumerable<DAO.Account>> result = new Result<IEnumerable<DAO.Account>>();
            try
            {
                result.Data = await unitOfWork.AccountRepository.GetAll();
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
        public async Task<Result<DAO.Account>> createNewAccount(DAO.Account account)
        {
            Result<DAO.Account> result = new Result<DAO.Account>();
            if (string.IsNullOrEmpty(account.Username) || string.IsNullOrEmpty(account.Password) || account.EmployeeID == 0
                || string.IsNullOrEmpty(account.Role))
            {
                result.Data = null;
                result.IsSuccess = false;
                result.ErrorMessage = "Please enter all information";
            }
            else
            {
                try
                {
                    result.Data = await unitOfWork.AccountRepository.Add(account);
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
        public async Task<Result<DAO.Account>> updateAccount(DAO.Account account)
        {
            Result<DAO.Account> result = new Result<DAO.Account>();
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
                    result.Data = await unitOfWork.AccountRepository.Update(account);
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
        public async Task<Result<Boolean>> deleteAccount(int accountId)
        {
            Result<Boolean> result = new Result<Boolean>();
            try
            {
                result.Data = await unitOfWork.AccountRepository.RemoveByID(accountId);
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
