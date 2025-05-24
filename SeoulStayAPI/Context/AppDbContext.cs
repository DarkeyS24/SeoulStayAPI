using Microsoft.EntityFrameworkCore;
using SeoulStayAPI.Models;

namespace SeoulStayAPI.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<User>(u =>
            { 
                u.HasKey(user => user.Id);
                u.Property(user => user.Guid).IsRequired().HasColumnType("uniqueidentifier");
                u.Property(user => user.UserTypeId).IsRequired();
                u.Property(user => user.Username).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
                u.Property(user => user.Password).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");
                u.Property(user => user.FullName).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");
                u.Property(user => user.BirthDate).IsRequired();
                u.Property(user => user.FamilyCount).IsRequired();
            });
        }
    }
}
