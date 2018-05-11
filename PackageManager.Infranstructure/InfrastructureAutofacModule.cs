using Autofac;
using PackageManager.Application.Repositories;
using PackageManager.Infranstructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace PackageManager.Infranstructure
{
    public class InfrastructureAutofacModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EfRepository>().As<IPackageManagerRepository> ().SingleInstance();
        }
    }
}
