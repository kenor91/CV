﻿namespace Models
{
    public class Education
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfSemesters { get; set; }
        public ICollection<Skill> TaughtSkills { get; set; } = new List<Skill>();

    }
}
