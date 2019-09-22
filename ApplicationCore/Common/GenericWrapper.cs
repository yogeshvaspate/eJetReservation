using System;
using ApplicationCore.Entities;
using ApplicationCore.Data;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Common
{
    public class GenericWrapper : IGenericWrapper
    {
        private GenericContext _genericContext;
        private ICustomerRepository  _customer;

        public GenericWrapper(GenericContext genericContext)
        {
            _genericContext = genericContext;
        }

        public ICustomerRepository Customer
        {
            get
            {
                if (_customer == null)
                {
                    _customer = new CustomerRepository(_genericContext);
                }

                return _customer;
            }
        }

        public void Save()
        {
            _genericContext.SaveChanges();
        }

    }
}
