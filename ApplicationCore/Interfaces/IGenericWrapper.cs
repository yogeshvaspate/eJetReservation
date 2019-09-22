using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface IGenericWrapper
    {
        ICustomerRepository Customer { get; }

        void Save();
    }
}
