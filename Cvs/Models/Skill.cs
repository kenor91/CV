namespace Models
{
    public class Skill
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Desctiption { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}
