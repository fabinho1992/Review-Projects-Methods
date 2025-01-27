using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Review_Projects.Infrastructure.DataContext;
using Review_Projects_Methods.Domain.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Projects.Extensions
{
    public static class ExtensionSettings
    {
        public static IServiceCollection AddDbContextReviewProjects(this IServiceCollection services, IConfiguration configuration)
        {

            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<DbReviewProjectsContext>(opt =>
                            opt.UseSqlServer(connectionString));

            return services;
        }

        public static IServiceCollection AddInjectionsDepedency(IServiceCollection services)
        {
            

            return services;
        }

    }
}
