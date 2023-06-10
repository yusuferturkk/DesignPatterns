using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ChainOfResponsibility_.DataAccessLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= DESKTOP-T4IFV09\\SQLSERVER; initial catalog= DbChainOfResp; integrated security= true;");
        }

        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
