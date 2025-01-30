using Review_Projects_Methods.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Projects_Methods.Domain.IRepository
{
    public interface IFeedBackRepository
    {
        Task CreateAsync(FeedBack feedBack);
        Task<FeedBack> GetByIdAsync(Guid id);
        Task<FeedBack> GetByMentor(Guid id);
        Task<IEnumerable<FeedBack>> GetAllAsync();
        Task DeleteAsync(FeedBack feedBack);
    }
}
