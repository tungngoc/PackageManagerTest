using PackageManager.Application.Repositories;
using PackageManager.Domain.Package;
using PackageManager.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using PackageManager.Application.Inputs;

namespace PackageManager.Application.UseCases.AddPackages
{
    public class AddPackageInteractor : IInputBoundary<AddPackageInput>
    {
        private readonly IPackageManagerRepository _packageManagerRepository;

        public AddPackageInteractor(IPackageManagerRepository packageManagerRepository)
        {
            _packageManagerRepository = packageManagerRepository;
        }

        public async Task Process(AddPackageInput input)
        {
            ValidatePakageInput(input);
            var package = MapPackage(input);
            await _packageManagerRepository.AddPackage(package);

        }

        private Package MapPackage(AddPackageInput inputPackage)
        {
            var package =  new Package
            {
                Id = inputPackage.Id,
                Name = inputPackage.Name,
                Products = inputPackage.Products.Select(p => new Product
                {
                    Id = p.Id,
                    Name = p.Name,
                    ProductType = p.ProductType
               }).ToList()
            };

            return package;
        }

        private void ValidatePakageInput(AddPackageInput input)
        {
            if (string.IsNullOrEmpty(input.Name)) throw new Exception("invalid Packgage name exception");
        }
    }
}
