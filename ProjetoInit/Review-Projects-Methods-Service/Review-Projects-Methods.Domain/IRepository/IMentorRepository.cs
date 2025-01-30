using Review_Projects_Methods.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Projects_Methods.Domain.IRepository
{
    public interface IMentorRepository
    {
        Task CreateAsync(Mentor mentor);
        Task<Mentor> GetByIdAsync(Guid id);
        Task<IEnumerable<Mentor>> GetAllAsync();
        Task DeleteAsync(Mentor mentor);
        void Update(Mentor mentor);
    }
}
