using Models;
using GraphQL.Types;

namespace Application.Types
{
    public class SkillType : ObjectGraphType<Skill>
    {
        public SkillType()
        {
            Name = "Skill";
            Field(x => x.Id).Description("Unique identifier");
            Field(x => x.Name);
            Field(x => x.Desctiption);
        }
    }
}
