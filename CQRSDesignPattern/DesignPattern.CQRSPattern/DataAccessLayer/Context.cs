using Microsoft.EntityFrameworkCore;

namespace DesignPattern.CQRSPattern.DataAccessLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= DESKTOP-T4IFV09\\SQLSERVER; initial catalog= DbCQRSPattern; integrated security= true;");
        }

        public DbSet<Product> Products { get; set; }
    }
}
