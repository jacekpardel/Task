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

}   
}
