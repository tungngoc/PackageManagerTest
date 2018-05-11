using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackageManagerAPI.Requests
{
    public class ProductRequest
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ProductType { get; set; }
       
    }
}
