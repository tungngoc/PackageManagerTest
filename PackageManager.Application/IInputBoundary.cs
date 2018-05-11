using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Application
{
    public interface IInputBoundary<T>
    {
        Task Process(T input);
    }
}
