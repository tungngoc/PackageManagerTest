using PackageManager.Application.Inputs;
using PackageManager.Application.Repositories;
using PackageManager.Domain.Package;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Application.UseCases.UpdatePackage
{
    public class UpdatePackageInteractor: IInputBoundary<UpdatePackageInput>
    {
        private readonly IPackageManagerRepository _packageManagerRepository;
        public UpdatePackageInteractor(IPackageManagerRepository packageManagerRepository)
        {
            _packageManagerRepository = packageManagerRepository;
        }
        public async Task Process(UpdatePackageInput input)
        {
            ValidatePakageInput(input);
            var package = MapPackage(input);
            await _packageManagerRepository.UpdatePackage(package);

        }

        private Package MapPackage(UpdatePackageInput inputPackage)
        {
            var package = new Package
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

        private void ValidatePakageInput(UpdatePackageInput input)
        {
            var package = _packageManagerRepository.GetPackageById(input.Id);
            if (package == null) throw new PackageNotFoundException("Invalid package");
        }
    }
}
