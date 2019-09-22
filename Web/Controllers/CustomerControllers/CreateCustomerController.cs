using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApplicationCore.Data;
using ApplicationCore.Entities;
using ApplicationCore.Common;
using ApplicationCore.Interfaces;

namespace Web.Controllers.CustomerControllers
{
    [Route("api/[controller]")]
    public class CreateCustomerController : Controller
    {
        private IGenericWrapper _wrapper;
            
        public CreateCustomerController(IGenericWrapper wrapper)
        {
            _wrapper = wrapper;
        }

        [HttpGet("{CustomerId}/{Title}/{FirstName}/{LastName}")]

        public async Task<string> AddCustomerById(int CustomerId, string Title, string FirstName, string LastName)
        {
            Customer customer = new Customer();
            customer.CustomerId = CustomerId;
            customer.Title = Title;
            customer.CustomerFirstName = FirstName;
            customer.CustomerLastName = LastName;

            _wrapper.Customer.Create(customer);
            _wrapper.Save();

            await Task.Delay(1);
            return "Customer Creation Request Sent";
        }
    }
}
