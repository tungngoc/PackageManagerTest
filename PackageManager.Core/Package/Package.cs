using PackageManager.Core.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace PackageManager.Domain.Package
{
    public class Package : BaseEntity
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
