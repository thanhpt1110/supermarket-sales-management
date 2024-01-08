using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementApp.ErrorHandle
{
    public class ExistedObjectException : Exception
    {
        public ExistedObjectException()
        {
        }

        public ExistedObjectException(string message)
            : base(message)
        {
        }

        public ExistedObjectException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
        public static bool IsUniqueConstraintViolation(DbUpdateException ex)
        {
            var sqlException = ex.InnerException?.InnerException as System.Data.SqlClient.SqlException;

            // Check if the SqlException is not null and its Number corresponds to a unique constraint violation
            return sqlException != null && (sqlException.Number == 2601 || sqlException.Number == 2627);
        }
    }
}
