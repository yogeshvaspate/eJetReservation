using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApplicationCore.Entities;
using ApplicationCore.Data;
using Microsoft.EntityFrameworkCore;

namespace Web.Controllers.CustomerControllers
{
    [Route("api/[controller]")]
    public class ReadCustomerController : Controller
    {
        private GenericContext _genericContext;

        public ReadCustomerController(GenericContext context)
        {
            _genericContext = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Customer>>> ReadCustomerById(int id)
        {
            return await _genericContext.Customers.Where(a => a.CustomerId == id).ToListAsync();
        }
    }
}

