using Infrastructure.EfCore;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Application.Services
{
    public interface ICVService
    {

        Task<CV> GetCV(int id);
        Task<List<CV>> GetCVs();
        Task<List<Project>> GetProjects(int cvId);
        Task<Education> GetEducation(int cvId);
        Task<List<Skill>> GetSkills(int cvId);
        Task<Company> GetCurrentEmployer(int cvId);

    }
    public class CVService : ICVService
    {
        private readonly CvContext context;
        public CVService(CvContext context)
        {
            this.context = context;
        }

        public async Task<CV> GetCV(int id) => await context.CVs.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
        public async Task<List<CV>> GetCVs() => await context.CVs.ToListAsync();

        public async Task<List<Project>> GetProjects(int cvId) => await context.CVs.Where(x => x.Id == cvId).SelectMany(x => x.Projects).ToListAsync();
        public async Task<Education> GetEducation(int cvId) => await context.CVs.Where(x => x.Id == cvId).Select(x => x.Education).FirstOrDefaultAsync();
       
        public async Task<List<Skill>> GetSkills(int cvId) => await context.CVs.Where(x => x.Id == cvId).SelectMany(x => x.Skills).ToListAsync();

        public Task<Company> GetCurrentEmployer(int cvId) => context.CVs.Where(x => x.Id == cvId).Select(x => x.CurrentEmployer).FirstOrDefaultAsync();
    }





}
