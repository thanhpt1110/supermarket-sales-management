using SupermarketManagementApp.ErrorHandle;
using SupermarketManagementApp.Infrastructure;
using SupermarketManagementApp.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementApp.BUS
{
    public class AccountBUS
    {
        private IUnitOfWork unitOfWork;
        public AccountBUS() {
            unitOfWork = new UnitOfWork();
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
            catch(NotExistedObjectException e)
            {
                result.Data = null;
                result.IsSuccess = false;
                result.ErrorMessage = e.Message;
            }
            catch (Exception ex)
            {
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
            catch (DbUpdateException e)
            {
                // Xử lý exception cụ thể, ví dụ: tài khoản đã tồn tại, ràng buộc duy nhất bị vi phạm, v.v.
                result.ErrorMessage = "Error while updating the database.";
                result.IsSuccess = false;
                result.Data = null;
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
            catch (DbUpdateException e)
            {
                // Xử lý exception cụ thể, ví dụ: tài khoản đã tồn tại, ràng buộc duy nhất bị vi phạm, v.v.
                result.ErrorMessage = "Error while updating the database.";
                result.IsSuccess = false;
                result.Data = null;
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
                    if(result.Data == null)
                    {
                        result.ErrorMessage = "Account already existed";
                        result.IsSuccess = false;
                        return result;
                    }
                    else
                    {
                        result.IsSuccess = true;
                        result.ErrorMessage = null;
                        return result;
                    }
                }
                catch (ExistedObjectException e)
                {
                    result.ErrorMessage = e.Message;
                    result.IsSuccess = false;
                    result.Data = null;
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
                    if (result.Data == null)
                    {
                        result.ErrorMessage = "Account not existed";
                        result.IsSuccess = false;
                        return result;
                    }
                    else
                    {
                        result.IsSuccess = true;
                        result.ErrorMessage = null;
                        return result;
                    }
                }
                catch (NotExistedObjectException e)
                {
                    result.ErrorMessage = e.Message;
                    result.IsSuccess = false;
                    result.Data = null;
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
    }
}
