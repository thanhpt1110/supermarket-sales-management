using System;
using System.Collections.Generic;
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
    }
}
