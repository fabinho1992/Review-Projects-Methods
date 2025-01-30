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
    public class MentoringRepository : IMentoringRepository
    {
        private readonly DbReviewProjectsContext _context;

        public MentoringRepository(DbReviewProjectsContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Mentoring mentoring)
        {
            await _context.AddAsync(mentoring);
        }

        public async Task DeleteAsync(Mentoring mentoring)
        {
            var deleteMentoring = await GetByIdAsync(mentoring.Id);
            _context.Remove(deleteMentoring);
        }

        public async Task<IEnumerable<Mentoring>> GetAllAsync()
        {
            return await _context.Mentorings.AsNoTracking()
                .ToListAsync();
        }

        public async Task<Mentoring> GetByIdAsync(Guid id)
        {
            var mentoring = await _context.Mentorings.Include(m => m.Projects)
                .SingleOrDefaultAsync(m => m.Id == id);

            return mentoring;
        }

        public void Update(Mentoring mentoring)
        {
            _context.Update(mentoring);
        }
    }
}
