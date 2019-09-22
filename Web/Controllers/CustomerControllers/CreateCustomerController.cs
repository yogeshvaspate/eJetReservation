using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApplicationCore.Data;
using ApplicationCore.Entities;

namespace Web.Controllers.CustomerControllers
{
    [Route("api/[controller]")]
    public class CreateCustomerController : Controller
    {
        private GenericContext _genericContext;

        public CreateCustomerController(GenericContext context)
        {
            _genericContext = context;
        }

        [HttpGet("{CustomerId}/{FirstName}/{LastName}")]
        public async Task<string> AddCustomerById(int CustomerId, string Title, string FirstName, string LastName)
        {
            Customer customer = new Customer();
            customer.CustomerId = CustomerId;
            customer.Title = Title;
            customer.CustomerFirstName = FirstName;
            customer.CustomerLastName = LastName;

            _genericContext.Customers.Add(customer);

            await Task.Delay(1);
            return "Customer Creation Request Sent";
        }
    }
}
