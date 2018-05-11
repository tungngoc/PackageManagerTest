using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackageManagerAPI.Requests
{
    public class AddPackageRequest
    {
        public string Name { get; set; }
        public IReadOnlyCollection<ProductRequest> Products { get; set; }
        
    }
}
