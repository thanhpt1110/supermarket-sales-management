using SupermarketManagementApp.DAO;
using SupermarketManagementApp.ErrorHandle;
using SupermarketManagementApp.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementApp.Infrastructure.Repository
{
    public class AccountRepository : GenericRepository<Account>
    {
        public AccountRepository(SupermarketContext context) : base(context)
        {
        }
        public AccountRepository():base()
        {
        }
        public override async Task<Account> FindByID(int id)
        {
            try
            {
                Account account = await base.FindByID(id);
                if (account == null)
                {
                    throw (new NotExistedObjectException("Account not existed"));
                }
                return account;
            }
            catch (Exception ex) { throw; }

        }
        public override async Task<IEnumerable<Account>> GetAll()
        {
            try
            {
                return await base.GetAll();
            }
            catch (Exception ex) { throw; }
        }
        public override async Task<Account> Update(Account entity)
        {
            try
            {
                var account = await context.Accounts.FindAsync(entity.AccountID);
                if (account == null)
                {
                    throw (new NotExistedObjectException("Account not existed"));
                }
                account.Username = entity.Username;
                account.Role = entity.Role;
                return await base.Update(account);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public override  Task<Account> Add(Account entity)
        {
            try
            {
                var account = context.Accounts.SingleOrDefault(p => p.Username == entity.Username);
                if (account != null)
                {
                    throw (new ExistedObjectException("Account already existed"));
                }
                return base.Add(entity);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public override async Task<Boolean> RemoveByID(int AccountID)
        {
            try
            {
                var account = await context.Accounts.SingleOrDefaultAsync<Account>(p => p.AccountID == AccountID);
                if (account == null)
                    return false;
                return await base.RemoveByID(AccountID);
            }
            catch {
                throw;
            }
        }
        
    }
}
