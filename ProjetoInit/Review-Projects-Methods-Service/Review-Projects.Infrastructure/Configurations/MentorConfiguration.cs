﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Review_Projects_Methods.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Projects.Infrastructure.Configurations
{
    public class MentorConfiguration : IEntityTypeConfiguration<Mentor>
    {
        public void Configure(EntityTypeBuilder<Mentor> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(50)
                .HasColumnType("NVARCHAR")
                .IsRequired();

            builder.Property(x => x.Email).HasMaxLength(50)
                .IsRequired();
            builder.HasIndex(x => x.Email)
                .IsUnique();

            builder.Property(x => x.TypeUser)
                .HasConversion<string>()
                .IsRequired();

            builder.HasMany(x => x.FeedBacks)
                .WithOne(x => x.Mentor)
                .HasForeignKey(x => x.MentorId);


        }
    }
}
