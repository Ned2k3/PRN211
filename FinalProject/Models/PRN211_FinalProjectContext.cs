using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FinalProject.Models
{
    public partial class PRN211_FinalProjectContext : DbContext
    {
        public PRN211_FinalProjectContext()
        {
        }

        public PRN211_FinalProjectContext(DbContextOptions<PRN211_FinalProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<Enroll> Enrolls { get; set; } = null!;
        public virtual DbSet<Scategory> Scategories { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                              .SetBasePath(Directory.GetCurrentDirectory())
                              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyCnn"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.AccountId).HasColumnName("accountID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(50)
                    .HasColumnName("fullname");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.Role).HasColumnName("role");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("Course");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CourseName).HasMaxLength(200);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Course__Category__4316F928");

                entity.HasOne(d => d.CreatorNavigation)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.Creator)
                    .HasConstraintName("FK__Course__Creator__3E52440B");
            });

            modelBuilder.Entity<Enroll>(entity =>
            {
                entity.ToTable("Enroll");

                entity.Property(e => e.EnrollId).HasColumnName("EnrollID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.EntrollDate).HasColumnType("datetime");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Enrolls)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK__Enroll__AccountI__412EB0B6");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Enrolls)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__Enroll__CourseID__4222D4EF");
            });

            modelBuilder.Entity<Scategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__Scategor__19093A2B15AC0914");

                entity.ToTable("Scategory");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
