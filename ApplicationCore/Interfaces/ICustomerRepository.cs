using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.Interfaces;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface ICustomerRepository : IGenericOperations<Customer>
    {
    }
}
