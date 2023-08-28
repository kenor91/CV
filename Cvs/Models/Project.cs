namespace Models
{
    public class Project
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }

        public virtual Company Company { get; set; }

        public virtual ICollection<Skill> RequiredSkills { get; set; }
    }
}
