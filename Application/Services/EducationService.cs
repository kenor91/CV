using Infrastructure.EfCore;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Application.Services
{
    public interface IEducationService
    {
        Task<Education> GetEducation(int educationId);
        Task<List<Education>> GetEducations();

    }
    public class EducationService : IEducationService
    {
        private readonly CvContext context;

        public EducationService(CvContext context)
        {
            this.context = context;
        }
        public async Task<Education> GetEducation(int educationId) => await context.Educations.FirstOrDefaultAsync(x => x.Id == educationId);

        public async Task<List<Education>> GetEducations() => await context.Educations.ToListAsync();
    }
}
