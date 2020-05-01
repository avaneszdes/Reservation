using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using Reservation.Entities;

namespace Reservation.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Reserv> Reservs { get; set; }

        public ApplicationDbContext() 
        {
           Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dBContextOptionBuilder)
        {
            dBContextOptionBuilder.UseSqlServer("server=.; database=helloappdb; integrated security=true;");
        }
            
    }
}
