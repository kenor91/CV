using Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EfCore
{
    public class CvContext : DbContext
    {

        public DbSet<Company> Companies { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Education> Educations { get; set; }

        public DbSet<CV> CVs { get; set; }

        public CvContext(DbContextOptions options) : base(options)
        {
            InitDemoData();
        }

        private void InitDemoData()
        {
            int companyId = 0;
            Companies.Add(new()
            {
                Id = ++companyId,
                Name = "Mindworking A/S"
            });
            Companies.Add(new()
            {
                Id = ++companyId,
                Name = "Elbek & Vejrup"
            });

            int skillId = 0;
            Skill graphQL = new()
            {
                Id = ++skillId,
                Name = "GraphQL",
                Desctiption = "",
            };
            Skill cHashtag = new()
            {
                Id = ++skillId,
                Name = "C sharp",
                Desctiption = "",
            };
            Skill efCore = new()
            {
                Id = ++skillId,
                Name = "Entity framework",
                Desctiption = ""
            };
            Skills.AddRange(new[]
{
                graphQL,
                cHashtag,
                efCore,
            });

            var education = new Education()
            {
                Id = 1,
                Name = "PBA Økonomi & IT",
            };
            Educations.Add(education);

            Projects.Add(new()
            {
                Description = "Build a CV application",
            });


            CVs.Add(new CV()
            {
                Id = 1,
                CurrentEmployerId = companyId,
                Name = "Kenneth",
                LastName = "Nordholm",
                Education = education,
                Skills = new List<Skill>()
                {
                    graphQL, cHashtag, efCore
                },
                Projects = new List<Project>() {
                    new ()
                    {
                         Description = "Reader for WOW dbc files written in rust"
                    },
                    new()
                    {
                        Description = "TCP packet sniffer for logging market data for Albion Online"
                    }
                }
            });

            SaveChanges();
        }
    }

}
