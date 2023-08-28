using Models;
using GraphQL.Types;
using Infrastructure.GraphQL.Types;


namespace Cvs.Schema
{
    public class CVQuery : ObjectGraphType<object>
    {
        public CVQuery(CompanyService service)
        {
            Name = "RootQuery";
            Field<CompanyType>("companies").Resolve(context => service.Queries.GetCompanies());

            Field<ProjectType>("project").Resolve(x => new Project
            {
                Id = 1
            });

            Field<SkillType>("skill").Resolve(x => new Skill
            {
                Id = 1
            });

            Field<EducationType>("education").Resolve(x => new Education
            {
                Id = 1
            });

        }
    }
}
