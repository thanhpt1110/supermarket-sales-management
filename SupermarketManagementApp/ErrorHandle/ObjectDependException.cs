using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementApp.ErrorHandle
{
    public class ObjectDependException: Exception
    {
        public ObjectDependException()
        {
        }

        public ObjectDependException(string message)
            : base(message)
        {
        }

        public ObjectDependException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
