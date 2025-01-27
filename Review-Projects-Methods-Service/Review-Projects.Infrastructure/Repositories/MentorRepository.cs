using Microsoft.EntityFrameworkCore;
using Review_Projects.Infrastructure.DataContext;
using Review_Projects_Methods.Domain.IRepository;
using Review_Projects_Methods.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Projects.Infrastructure.Repositories
{
    public class MentorRepository : IMentorRepository
    {
        private readonly DbReviewProjectsContext _context;

        public MentorRepository(DbReviewProjectsContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Mentor mentor)
        {
            await _context.AddAsync(mentor);
        }

        public Task DeleteAsync(Mentor mentor)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Mentor>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Mentor> GetByIdAsync(Guid id)
        {
            var mentor = await _context.Mentors.Include(m => m.FeedBacks)
                .SingleOrDefaultAsync(m => m.Id == id);

            return mentor;
        }

        public void Update(Mentor mentor)
        {
            throw new NotImplementedException();
        }
    }
}
