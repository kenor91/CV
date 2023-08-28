using Models;
using GraphQL.Types;

namespace Infrastructure.GraphQL.Types
{
    public class ProjectType : ObjectGraphType<Project>
    {
        public ProjectType()
        {
            Name = "Project";
            Field(x => x.Id).Description("Unique identifier");
        }
    }
}
