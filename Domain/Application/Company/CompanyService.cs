
using Infrastructure.EfCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Company
{
    public class CompanyService
    {
        public CompanyCommands Commands { get; private set; }
        public CompanyQueries Queries { get; private set; }
        public CompanyService(CvContext context)
        {
            Commands = new CompanyCommands(context);
            Queries = new CompanyQueries(context);
        }
    }

    public partial class CompanyCommands
    {
        private readonly CvContext context;
        public CompanyCommands(CvContext context)
        {
            this.context = context;
        }
    }
    public partial class CompanyQueries
    {
        private readonly CvContext context;
        public CompanyQueries(CvContext context)
        {
            this.context = context;
        }
    }


}
