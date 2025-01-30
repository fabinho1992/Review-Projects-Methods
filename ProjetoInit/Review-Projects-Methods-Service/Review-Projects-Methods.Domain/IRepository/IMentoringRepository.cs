using Review_Projects_Methods.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Projects_Methods.Domain.IRepository
{
    public interface IMentoringRepository
    {
        Task CreateAsync(Mentoring mentoring);
        Task<Mentoring> GetByIdAsync(Guid id);
        Task<IEnumerable<Mentoring>> GetAllAsync();
        Task DeleteAsync(Mentoring mentoring);
        void Update(Mentoring mentoring);
    }
}
