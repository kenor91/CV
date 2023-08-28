using GraphQL.Types;
using Models;

namespace Infrastructure.GraphQL.Types
{
    public class CompanyType : ObjectGraphType<Company>
    {
        public CompanyType()
        {
            Name = "Company";
            Field(x => x.Id).Description("Unique identifier");
        }
    }
}
