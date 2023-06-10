using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Composite.DataAccessLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= DESKTOP-T4IFV09\\SQLSERVER; Database= DbCompositePattern; Trusted_Connection= true;");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
