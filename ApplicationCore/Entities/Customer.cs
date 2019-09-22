using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ApplicationCore.Data;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Entities
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string Title { get; set;  }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
    }

    public class CustomerRepository : GenericOperations<Customer>, ICustomerRepository
    {
        public CustomerRepository(GenericContext genericContext) : base(genericContext)
        {
        }
    }

}
