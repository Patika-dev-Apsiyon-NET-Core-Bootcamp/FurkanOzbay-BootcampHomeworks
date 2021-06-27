using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlogProject.DataLayer.Models
{
    public partial class BlogProjectDbContext : DbContext
    {
        public BlogProjectDbContext()
        {
        }

        public BlogProjectDbContext(DbContextOptions<BlogProjectDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Blogs> Blogs { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-KUV1GT2;Database=BlogProjectDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blogs>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Blogs)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Blogs_CategoryId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Blogs)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Blogs_UserId");
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Comments>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Comments_UserId");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Password).HasMaxLength(20);

                entity.Property(e => e.UserName).HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
