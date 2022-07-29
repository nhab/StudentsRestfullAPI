using Microsoft.EntityFrameworkCore;

namespace StudentsRestfullAPI.DB
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        { 
        }
        public DbSet<Student> Students { get; set; }    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);   
        }
    }
}
