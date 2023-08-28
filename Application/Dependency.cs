using Application.Schema;
using Application.Services;
using GraphQL;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class Dependency
    {

        public static IServiceCollection AddGraphQL(this IServiceCollection services)
        {
            services.AddGraphQL(b => b
                .AddSchema<CVSchema>()
                .AddSystemTextJson()
                .AddGraphTypes(typeof(CVSchema).Assembly)
                );
            return services;
        }


        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddSingleton<ICompanyService, CompanyService>();
            services.AddSingleton<IEducationService, EducationService>();
            services.AddSingleton<IProjectService, ProjectService>();
            services.AddSingleton<ISkillService, SkillService>();
            services.AddSingleton<ICVService, CVService>();
            services.AddSingleton<CVQuery>();

            return services;
        }

        public static IApplicationBuilder UseGraphQL(this IApplicationBuilder app, bool usePlayground = false)
        {
            app.UseGraphQL<CVSchema>();
            if (usePlayground)
                app.UseGraphQLPlayground(options: new GraphQL.Server.Ui.Playground.PlaygroundOptions
                {

                });
            return app;
        }
    }
}
