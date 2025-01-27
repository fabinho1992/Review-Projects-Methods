﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Review_Projects.Infrastructure.DataContext;

#nullable disable

namespace Review_Projects.Infrastructure.Migrations
{
    [DbContext(typeof(DbReviewProjectsContext))]
    partial class DbReviewProjectsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Review_Projects_Methods.Domain.Models.FeedBack", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Coment")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("NVARCHAR");

                    b.Property<Guid>("MentorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("MentorId");

                    b.HasIndex("ProjectId");

                    b.ToTable("FeedBacks");
                });

            modelBuilder.Entity("Review_Projects_Methods.Domain.Models.Mentor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR");

                    b.Property<string>("TypeUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Mentors");
                });

            modelBuilder.Entity("Review_Projects_Methods.Domain.Models.Mentoring", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR");

                    b.Property<string>("TypeUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Mentorings");
                });

            modelBuilder.Entity("Review_Projects_Methods.Domain.Models.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("NVARCHAR");

                    b.Property<string>("LinkGit")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR");

                    b.Property<Guid>("MentoringId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR");

                    b.HasKey("Id");

                    b.HasIndex("MentoringId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Review_Projects_Methods.Domain.Models.FeedBack", b =>
                {
                    b.HasOne("Review_Projects_Methods.Domain.Models.Mentor", "Mentor")
                        .WithMany("FeedBacks")
                        .HasForeignKey("MentorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Review_Projects_Methods.Domain.Models.Project", "Project")
                        .WithMany("FeedBacks")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mentor");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Review_Projects_Methods.Domain.Models.Project", b =>
                {
                    b.HasOne("Review_Projects_Methods.Domain.Models.Mentoring", "Mentoring")
                        .WithMany("Projects")
                        .HasForeignKey("MentoringId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mentoring");
                });

            modelBuilder.Entity("Review_Projects_Methods.Domain.Models.Mentor", b =>
                {
                    b.Navigation("FeedBacks");
                });

            modelBuilder.Entity("Review_Projects_Methods.Domain.Models.Mentoring", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("Review_Projects_Methods.Domain.Models.Project", b =>
                {
                    b.Navigation("FeedBacks");
                });
#pragma warning restore 612, 618
        }
    }
}
