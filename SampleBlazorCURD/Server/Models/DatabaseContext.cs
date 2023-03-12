using Microsoft.EntityFrameworkCore;
using SampleBlazorCURD.Shared;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System;

namespace SampleBlazorCURD.Server.Models
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
            
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options) 
        {
            
        }
        public DbSet<ManufacturingCompany> Companies { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = manufacture; Integrated Security = True;");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<User>(entity =>
        //    {
        //        entity.ToTable("userdetails");
        //        entity.Property(e => e.UserId).HasColumnName("Userid");
        //        entity.Property(e => e.UserName)
        //            .HasMaxLength(100)
        //            .IsUnicode(false);
        //        entity.Property(e => e.Address)
        //            .HasMaxLength(500)
        //            .IsUnicode(false);
        //        entity.Property(e => e.PhoneNumber)
        //            .HasMaxLength(50)
        //            .IsUnicode(false);
        //        entity.Property(e => e.EmailId)
        //            .HasMaxLength(50)
        //            .IsUnicode(false);
        //    });
        //    OnModelCreatingPartial(modelBuilder);
        //}

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
