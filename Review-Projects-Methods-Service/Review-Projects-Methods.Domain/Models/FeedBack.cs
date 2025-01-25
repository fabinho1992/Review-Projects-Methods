namespace Review_Projects_Methods.Domain.Models
{
    public class FeedBack
    {
        public FeedBack(Guid id, Guid mentorId, Guid projectId, string coment)
        {
            Id = id;
            MentorId = mentorId;
            ProjectId = projectId;
            Coment = coment;
        }

        public Guid Id { get; private set; }
        public Guid MentorId { get; private set; }
        public Guid ProjectId { get; private set; }
        public string Coment { get; private set; }
        public virtual Mentor? Mentor { get; private set; }
        public virtual Project? Project { get; private set; }
    }
}