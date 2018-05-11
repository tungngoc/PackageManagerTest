﻿using PackageManager.Application.Inputs;
using System;
using System.Collections.Generic;
using System.Text;

namespace PackageManager.Application.UseCases.AddPackages
{
    public class AddPackageInput
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<ProductInput> Products { get; set; }
    }
}
