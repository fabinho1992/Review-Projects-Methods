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
    public class FeedBackConfiguration : IEntityTypeConfiguration<FeedBack>
    {
        public void Configure(EntityTypeBuilder<FeedBack> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.MentorId)
               .IsRequired();

            builder.Property(x => x.ProjectId)
               .IsRequired();

            builder.Property(x => x.Coment).HasMaxLength(250)
                .HasColumnType("NVARCHAR")
                .IsRequired();


        }
    }
}
