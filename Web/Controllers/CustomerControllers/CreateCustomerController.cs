using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApplicationCore.Data;
using ApplicationCore.Entities;
using ApplicationCore.Common;
using ApplicationCore.Interfaces;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Web.Controllers.CustomerControllers
{
    [Route("api/[controller]")]
    public class CreateCustomerController : Controller
    {
        private IGenericWrapper _wrapper;
        private GenericContext _genericContext;

        public CreateCustomerController(IGenericWrapper wrapper, GenericContext context)
        {
            _wrapper = wrapper;
            _genericContext = context;
        }

        [HttpGet("{CustomerId}/{Title}/{FirstName}/{LastName}")]

        public async Task<string> AddCustomerById(int CustomerId, string Title, string FirstName, string LastName)
        {
            Customer customer = new Customer();
            customer.CustomerId = CustomerId;
            customer.Title = Title;
            customer.CustomerFirstName = FirstName;
            customer.CustomerLastName = LastName;

            var CustomerIdExists =  _genericContext.Customers.Where(a => a.CustomerId == CustomerId).ToList();
            if (CustomerIdExists.Count > 0)
            {
                await Task.Delay(1);
                return "Customer Creation Failed - Customer Id exists";
            }
            else
            {
                _wrapper.Customer.Create(customer);
                _wrapper.Save();

                await Task.Delay(1);
                return "Customer Creation Request Sent";
            }
        }
    }
}
