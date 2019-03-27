using bff.Models;
using GraphQL.Types;

namespace bff.Types
{
    public class CustomerType: ObjectGraphType<Customer>
    {
        public CustomerType()
        {
            Name = "Customer";
            Description = "A customer";

            Field(t => t.CustomerId).Description("The ID of the customer");
            Field(t => t.FirstName).Description("The first name of the customer");
            Field(t => t.LastName).Description("The last name of the customer");
            Field(t => t.Email).Description("The email address of the customer");
            Field(t => t.Address).Description("The address of the customer");
            Field(t => t.PostalCode).Description("The postalcode of the customer");
            Field(t => t.City).Description("The city of the customer");
            Field(t => t.Country).Description("The country of the customer");
        }
    }
}