using Review_Projects_Methods.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Projects_Methods.Domain.IRepository
{
    public interface IProjectRepository
    {
        Task CreateAsync(Project project);
        Task<Project> GetByIdAsync(Guid id);
        Task<IEnumerable<Project>> GetAllAsync();
        Task<Project> GetByMentoring(Guid id);
        Task DeleteAsync(Project project);
        void Update(Project project);
    }
}
