using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Data
{
    public abstract class GenericOperations<T> : IGenericOperations<T> where T : class
    {
        internal GenericContext GenericContext { get; set; }

        public GenericOperations(GenericContext repositoryContext)
        {
            this.GenericContext = repositoryContext;
        }

        public void Create(T entity)
        {
            this.GenericContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.GenericContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.GenericContext.Set<T>().Remove(entity);
        }
    }
}
