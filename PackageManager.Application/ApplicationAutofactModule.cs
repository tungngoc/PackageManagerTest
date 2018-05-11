using Autofac;
using PackageManager.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using PackageManager.Domain.Shared;
using PackageManager.Application.Inputs;
using PackageManager.Application.UseCases.AddPackages;
using PackageManager.Application.UseCases.UpdatePackage;

namespace PackageManager.Application
{
    public class ApplicationAutofactModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AddPackageInteractor>().As<IInputBoundary<AddPackageInput>>().SingleInstance();
            builder.RegisterType<UpdatePackageInteractor>().As<IInputBoundary<UpdatePackageInput>>().SingleInstance();

        }
    }
}
