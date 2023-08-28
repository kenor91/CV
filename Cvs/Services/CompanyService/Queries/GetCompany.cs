using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvs
{
    public partial class CompanyQueries
    {
        public async Task GetCompany(int id) => await context.Companies.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
    }
}
