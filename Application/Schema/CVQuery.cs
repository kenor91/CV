using GraphQL.Types;
using Application.Types;
using Application.Services;
using GraphQL;

namespace Application.Schema
{
    public class CVQuery : ObjectGraphType<object>
    {
        public CVQuery(
            ICompanyService service,
            IProjectService projectService,
            ISkillService skillService,
            IEducationService educationService,
            ICVService cvService
            )
        {
            Name = "Query";
            Field<ListGraphType<CompanyType>>("companies").ResolveAsync(async context => await service.GetCompanies());
            Field<CompanyType>("company").Argument<int>("id").ResolveAsync(async context => await service.GetCompany(context.GetArgument<int>("id")));

            Field<ListGraphType<ProjectType>>("projects").ResolveAsync(async x => await projectService.GetProjects());

            Field<ListGraphType<SkillType>>("skills").ResolveAsync(async x => await skillService.GetSkills());

            Field<ListGraphType<EducationType>>("educations").ResolveAsync(async x => await educationService.GetEducations());

            Field<ListGraphType<CVType>>("cvs").ResolveAsync(async x => await cvService.GetCVs());
            Field<CVType>("cv").Argument<int>("id").ResolveAsync(async context => await cvService.GetCV(context.GetArgument<int>("id")));

        }
    }
}
