using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Mediator.DataAccessLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= DESKTOP-T4IFV09\\SQLSERVER; initial catalog= DbMediator; integrated security= true;");
        }

        public DbSet<Product> Products { get; set; }
    }
}
