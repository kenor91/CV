using Microsoft.EntityFrameworkCore;
using Models;

namespace Cvs
{
    public partial class CompanyQueries
    {
        public async Task<List<Company>> GetCompanies()
        {
            return await context.Companies.ToListAsync();
        }
    }
}
