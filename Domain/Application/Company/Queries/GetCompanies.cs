using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Company
{
    public partial class CompanyQueries
    {
        public async Task<List<Infrastructure.Models.Company>> GetCompanies()
        {
            return await context.Companies.ToListAsync();
        }
    }
}
