namespace Review_Projects_Methods.Domain.Models
{
    public class Project
    {
        public Project( Guid mentoringId, string name, string description, string linkGit, List<FeedBack> feedBacks)
        {
            Id = Guid.NewGuid();
            MentoringId = mentoringId;
            Name = name;
            Description = description;
            LinkGit = linkGit;
            FeedBacks = feedBacks;
        }

        public Guid Id { get; private set; }
        public Guid MentoringId { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string LinkGit { get; private set; }
        public virtual Mentor? Mentor { get; private set; }
        public List<FeedBack> FeedBacks { get; set; } = new();
    }
}