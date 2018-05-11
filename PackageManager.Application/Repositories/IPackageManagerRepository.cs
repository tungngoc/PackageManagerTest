using PackageManager.Domain.Package;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Application.Repositories
{
    public interface IPackageManagerRepository
    {
        Task AddPackage(Package package);
        Task UpdatePackage(Package package);
        Task<Package> GetPackageById(long id);
    }
}
