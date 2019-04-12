using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BingeWatcher.API.Helpers
{
    public class AppException : Exception
    {
        public AppException(string message)
            : base(message)
        {
        }

        public AppException(string message, params object[] args)
            : base(string.Format(CultureInfo.CurrentCulture, message, args))
        {
        }

        public AppException() : base()
        {
        }

        public AppException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
