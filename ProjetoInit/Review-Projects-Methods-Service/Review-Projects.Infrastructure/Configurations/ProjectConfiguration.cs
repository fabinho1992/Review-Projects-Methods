using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Review_Projects_Methods.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Projects.Infrastructure.Configurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.MentoringId)
                .IsRequired();

            builder.Property(x => x.Name).HasMaxLength(50)
                .HasColumnType("NVARCHAR")
                .IsRequired();

            builder.Property(x => x.Description).HasMaxLength(250)
                .HasColumnType("NVARCHAR")
                .IsRequired();

            builder.Property(x => x.LinkGit).HasMaxLength(100)
                .HasColumnType("NVARCHAR")
                .IsRequired();

            builder.HasMany(x => x.FeedBacks)
                .WithOne(x => x.Project)
                .HasForeignKey(x => x.ProjectId);


        }
    }
}
