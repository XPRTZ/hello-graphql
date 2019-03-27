using bff.Repository;
using bff.Types;
using GraphQL.Types;

namespace bff
{
    public class ChinookQuery : ObjectGraphType
    {
        public ChinookQuery(CustomerRepository customerRepository)
        {
            FieldAsync<ListGraphType<CustomerType>>(
                "customers",
                resolve: async context => 
                { 
                    return await customerRepository.GetAllAsync();
                }
            );
        }
    }
}