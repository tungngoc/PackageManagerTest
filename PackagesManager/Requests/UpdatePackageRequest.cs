using PackageManagerAPI.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackageManager.API.Requests
{
    public class UpdatePackageRequest
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public IReadOnlyCollection<ProductRequest> Products { get; set; }
    }
}
