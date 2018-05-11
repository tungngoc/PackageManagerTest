using PackageManager.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace PackageManager.Domain.Package
{
    public class PackageNotFoundException: DomainException
    {
        public PackageNotFoundException(string message)
          : base(message)
        { }
    }
}
