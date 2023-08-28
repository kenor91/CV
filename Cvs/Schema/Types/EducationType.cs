using Models;
using GraphQL.Types;

namespace Infrastructure.GraphQL.Types
{
    public class EducationType : ObjectGraphType<Education>
    {
        public EducationType()
        {
            Name = "Education";
            Field(x => x.Id).Description("Unique identifier");
        }
    }
}
