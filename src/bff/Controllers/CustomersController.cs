using System.Collections.Generic;
using System.Threading.Tasks;
using bff.Models;
using bff.Repository;
using Microsoft.AspNetCore.Mvc;

namespace bff.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        private readonly CustomerRepository _customerRepository;
        public CustomersController(CustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> Get()
        {
            var customers = await _customerRepository.GetAllAsync();

            return Ok(customers);
        }
    }
}