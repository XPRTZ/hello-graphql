using GraphQL;
using GraphQL.Types;

namespace bff
{
    public class ChinookSchema : Schema
    {
        public ChinookSchema(IDependencyResolver resolver): base(resolver)
        {
            Query = resolver.Resolve<ChinookQuery>();
        }
    }
}