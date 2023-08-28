using Infrastructure.EfCore;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Application.Services
{
    public interface ISkillService
    {
        Task<Skill> GetSkill(int skillId);
        Task<List<Skill>> GetSkills();
    }
    public class SkillService : ISkillService
    {
        private readonly CvContext context;

        public SkillService(CvContext context)
        {
            this.context = context;
        }
        public async Task<Skill> GetSkill(int skillId) => await context.Skills.FirstOrDefaultAsync(x => x.Id == skillId);
        public async Task<List<Skill>> GetSkills() => await context.Skills.ToListAsync();
    }
}
