using System;
using System.Collections.Generic;
using System.Text;

namespace PackageManager.Application
{
    public interface IOutputBoundary<T>
    {
        T Output { get; }
        void Populate(T response);
    }
}
