using Microsoft.EntityFrameworkCore;

namespace CursoMVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(local);Database=Cursomvc; user id=sa; password=Dev#1234;");
        }
    }
}