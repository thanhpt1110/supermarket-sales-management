using SupermarketManagementApp.DTO;
using SupermarketManagementApp.ErrorHandle;
using SupermarketManagementApp.Utils;
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
    public class AccountRepositoryDAO : GenericRepositoryDAO<Account>
    {
        public AccountRepositoryDAO(SupermarketContext context) : base(context)
        {
        }
        public AccountRepositoryDAO():base()
        {
        }
        public override async Task<Account> FindByID(long id)
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
                var account = await context.Accounts.FindAsync(entity.AccountID) ?? throw (new NotExistedObjectException("Account not existed"));
                if (account.Username != entity.Username && await context.Accounts.SingleOrDefaultAsync(p=>p.Username == entity.Username)!=null)
                {
                    throw new ExistedObjectException("This username is already existed");
                }
                account.Username = entity.Username;
                account.Password = entity.Password;
                account.Role = entity.Role;
                context.Accounts.AddOrUpdate(account);
                await context.SaveChangesAsync();
                return account;
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
        public override async Task<Boolean> RemoveByID(long AccountID)
        {
            try
            {
                var account = await context.Accounts.SingleOrDefaultAsync<Account>(p => p.AccountID == AccountID);
                if (account == null)
                {
                    throw (new NotExistedObjectException("Account already existed"));
                }
                return await base.RemoveByID(AccountID);
            }
            catch {
                throw;
            }
        }
        public override Task<IEnumerable<Account>> Find(Expression<Func<Account, bool>> predicate)
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
