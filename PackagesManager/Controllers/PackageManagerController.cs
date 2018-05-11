using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PackageManager.API.Requests;
using PackageManager.Application;
using PackageManager.Application.Inputs;
using PackageManager.Application.UseCases.AddPackages;
using PackageManager.Application.UseCases.UpdatePackage;
using PackageManagerAPI.Requests;


namespace PackagesManager.Controllers
{
    [Route("api/[controller]")]
    public class PackageManagerController : Controller
    {
        private readonly IInputBoundary<AddPackageInput> _addPackagesInput;
        private readonly IInputBoundary<UpdatePackageInput> _updatePackagesInput;   
        
        public PackageManagerController(IInputBoundary<AddPackageInput> addPackagesInput, IInputBoundary<UpdatePackageInput> updatePackagesInput)
        {
            _addPackagesInput = addPackagesInput;
            _updatePackagesInput = updatePackagesInput;
        }
       
        [HttpPost("addpackages")]
        public async Task<IActionResult> AddPackages([FromBody] AddPackageRequest package)
        {
            if (package == null) throw new Exception("Invalid Package");
            var input = new AddPackageInput()
            {
                Name = package.Name,
                Products = package.Products.Select(p => new ProductInput()
                {
                    Name = p.Name,
                    ProductType = p.ProductType
                }).ToList()
            };
            await _addPackagesInput.Process(input);
            return Ok();
            
        }
       
        [HttpPost("updatepackage")]
        public async Task<IActionResult> UpdatePackage([FromBody] UpdatePackageRequest package)
        {
            if (package == null) throw new Exception("Invalid Package");

            var input = new UpdatePackageInput()
            {
                Id = package.Id,
                Name = package.Name,
                Products = package.Products.Select(p => new ProductInput()
                {
                    Id = p.Id,
                    Name = p.Name,
                    ProductType = p.ProductType
                }).ToList()
            };
            await _updatePackagesInput.Process(input);
            return Ok();

        }
    }
}
