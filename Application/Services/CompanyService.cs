using Infrastructure.EfCore;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface ICompanyService
    {
        Task<Company> GetCompany(int companyId);
        Task<List<Company>> GetCompanies();
        Task<List<Project>> GetProjects(int companyId);
    }
    public class CompanyService : ICompanyService
    {
        private readonly CvContext context;
        public CompanyService(CvContext context)
        {
            this.context = context;
        }

        public async Task<Company> GetCompany(int companyId) => await context.Companies.AsNoTracking().FirstOrDefaultAsync(c => c.Id == companyId);
        public async Task<List<Company>> GetCompanies() => await context.Companies.ToListAsync();
        public async Task<List<Project>> GetProjects(int companyId) => await context.Companies.Where(x => x.Id == companyId).SelectMany(x => x.Projects).ToListAsync();
    }

}
