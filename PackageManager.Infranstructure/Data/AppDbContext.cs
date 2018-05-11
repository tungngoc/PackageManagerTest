using Microsoft.EntityFrameworkCore;
using PackageManager.Domain.Package;
using System;
using System.Collections.Generic;
using System.Text;


namespace PackageManager.Infranstructure.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {  
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Package> Packages { get; set; }
    }
}
