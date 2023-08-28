using Models;
using GraphQL.Types;

namespace Application.Types
{
    public class ProjectType : ObjectGraphType<Project>
    {
        public ProjectType()
        {
            Name = "Project";
            Field(x => x.Id).Description("Unique identifier");
            Field(x => x.Description);
        }
    }
}
