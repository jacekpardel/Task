using Microsoft.EntityFrameworkCore;
using Task.Models;

namespace IS_Task.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<LecturerModel> Lecturers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LecturerModel>().HasData(
                new LecturerModel {Id=1,Name="Jan",Email="jan@poczta.pl", Phone=55554},
                new LecturerModel { Id = 2, Name = "Piotr", Email = "piotr@poczta.pl", Phone = 54332 },
                new LecturerModel { Id = 3, Name = "Maciej", Email = "maciek@poczta.pl", Phone = 53454 });
        }
    }
}