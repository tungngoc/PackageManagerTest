using System;
using System.Collections.Generic;
using System.Text;

namespace PackageManager.Domain.Shared
{
    public class DomainException: BaseException
    {
        public string BusinessMessage { get; private set; }

        public DomainException(string businessMessage)
        {
            BusinessMessage = businessMessage;
        }
    }
}
