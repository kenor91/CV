using Infrastructure.EfCore;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Application.Services
{
    public interface IProjectService
    {
        Task<Project> GetProject(int projectId);
        Task<List<Project>> GetProjects();
    }
    public class ProjectService : IProjectService
    {
        private readonly CvContext context;

        public ProjectService(CvContext context)
        {
            this.context = context;
        }

        public async Task<Project> GetProject(int projectId) => await context.Projects.FirstOrDefaultAsync(p => p.Id == projectId);

        public async Task<List<Project>> GetProjects() => await context.Projects.ToListAsync();
    }
}
