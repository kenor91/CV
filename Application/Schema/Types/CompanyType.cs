using Application.Services;
using GraphQL.Types;
using Models;

namespace Application.Types
{
    public class CompanyType : ObjectGraphType<Company>
    {
        public CompanyType(ICompanyService companyService)
        {
            Name = "Company";
            Field(x => x.Id).Description("Unique identifier");
            Field(x => x.Name);
            Field<ListGraphType<ProjectType>>("projects").ResolveAsync(async context => await companyService.GetProjects(context.Source.Id));
        }
    }
}
