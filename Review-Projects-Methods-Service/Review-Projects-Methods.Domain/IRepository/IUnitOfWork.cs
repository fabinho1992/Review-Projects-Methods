using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Projects_Methods.Domain.IRepository
{
    public interface IUnitOfWork
    {
        IMentoringRepository MentoringRepository { get; }
        IMentorRepository MentorRepository { get; }
        IFeedBackRepository FeedBackRepository { get; }
        IProjectRepository ProjectRepository { get; }
        Task Commit();
    }
}
