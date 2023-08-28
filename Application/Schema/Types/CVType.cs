using Application.Services;
using GraphQL.Types;
using Models;

namespace Application.Types
{
    public class CVType : ObjectGraphType<CV>
    {
        public CVType(ICVService cvService)
        {
            Name = "CV";
            Field(x => x.Id).Description("Unique identifier");
            Field(x => x.FullName);

            Field<CompanyType>("currentEmployer").ResolveAsync(async context => await cvService.GetCurrentEmployer(context.Source.Id));
            Field<ListGraphType<ProjectType>>("hobbyProjects").ResolveAsync(async context => await cvService.GetProjects(context.Source.Id));
            Field<ListGraphType<SkillType>>("skills").ResolveAsync(async context => await cvService.GetSkills(context.Source.Id));
            Field<EducationType>("education").ResolveAsync(async context => await cvService.GetEducation(context.Source.Id));
        }
    }
}
