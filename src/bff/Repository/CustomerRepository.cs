using System.Collections.Generic;
using System.Threading.Tasks;
using bff.Models;
using Microsoft.EntityFrameworkCore;

namespace bff.Repository
{   
    public class CustomerRepository
    {
        private readonly ChinookContext _dbContext;

        public CustomerRepository(ChinookContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _dbContext.Customer.ToListAsync();
        }
    }
}