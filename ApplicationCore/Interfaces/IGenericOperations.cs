using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface IGenericOperations<T>
    {
        void Create(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
