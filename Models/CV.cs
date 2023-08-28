using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CV
    {
        public int Id { get; set; }

        public int? CurrentEmployerId { get; set; }
        public int EducationId { get; set; }

        public string Name { get; set; }
        public string LastName { get; set; }

        public Company CurrentEmployer { get; set; }
        public Education Education { get; set; }
        public ICollection<Project> Projects { get; set; }
        public ICollection<Skill> Skills { get; set; }
        public string FullName { get => $"{Name} {LastName}"; }
    }
}
