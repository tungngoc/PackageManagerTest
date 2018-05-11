using PackageManager.Core.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace PackageManager.Domain.Package
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string ProductType { get; set; }
        public int PackageId { get; set; }
        public Package Package { get; set; }
    }
}
