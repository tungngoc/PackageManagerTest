using Microsoft.EntityFrameworkCore;
using PackageManager.Application.Repositories;
using PackageManager.Core.Shared;
using PackageManager.Domain.Package;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Infranstructure.Data
{
    class EfRepository : IPackageManagerRepository
    {
        private readonly AppDbContext _dbContext;
        public EfRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddPackage(Package package)
        {
            await _dbContext.Packages.AddAsync(package);
            await _dbContext.SaveChangesAsync();
            var addPackage = _dbContext.Packages.ToList();//Remvoe this line
        }

        public async Task UpdatePackage(Package package)
        {
            var existPackage = await _dbContext.Packages.FirstOrDefaultAsync(t => t.Id == package.Id);

            if (existPackage == null) throw new Exception("invalid package");
            
            UpdatePackageInfo(package, existPackage);
            UpdateProductsInPackage(package, existPackage);

            await _dbContext.SaveChangesAsync();

        }

        private void UpdateProductsInPackage(Package newPackage, Package oldPackage)
        {
            
            var newProductIds = newPackage.Products.Select(t => t.Id);
            foreach (var product in newPackage.Products)
            {
                if (product.Id <= 0)
                {
                    oldPackage.Products.Add(product);
                    continue;
                }

                var existProduct = oldPackage.Products.FirstOrDefault(t => t.Id == product.Id);
                if (existProduct != null)
                {
                    existProduct.Name = product.Name;
                    existProduct.ProductType = product.ProductType;
                    continue;
                }
            }

           oldPackage.Products = oldPackage.Products.Where(t => newProductIds.Contains(t.Id)).ToList();
        }

        private void UpdatePackageInfo(Package newPackage, Package oldPackage)
        {
            oldPackage.Name = newPackage.Name;
        }

        public async Task<Package> GetPackageById(long id)
        {
            var existPackage = await _dbContext.Packages.FirstOrDefaultAsync(t => t.Id == id);
            return existPackage;
        }
    }
}
