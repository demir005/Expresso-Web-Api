using ExpressoWebApi.Models;
using System.Data.Entity;


namespace ExpressoWebApi.Data
{
    public class ExpressoDbContext : DbContext
    {
        public DbSet<Menu> Menus { get; set; }

        public DbSet<Reservation> Reservations { get; set; }


    }
}