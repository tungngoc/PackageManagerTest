using System;
using System.Collections.Generic;
using System.Text;

namespace PackageManager.Domain.Shared
{
    public class BaseException: Exception
    {
        internal BaseException()
        { }

        internal BaseException(string message)
            : base(message)
        { }

        internal BaseException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
