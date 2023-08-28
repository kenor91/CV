using Models;
using GraphQL.Types;

namespace Infrastructure.GraphQL.Types
{
    public class SkillType : ObjectGraphType<Skill>
    {
        public SkillType()
        {
            Name = "Skill";
            Field(x => x.Id).Description("Unique identifier");
        }
    }
}
