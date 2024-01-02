using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementApp.ErrorHandle
{
    public class NotExistedObjectException : Exception
    {
        public NotExistedObjectException()
        {
        }

        public NotExistedObjectException(string message)
            : base(message)
        {
        }

        public NotExistedObjectException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
