using WeflyAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace WeflyAPI.Infrastructure
{
    public class clsWeflyDbContext : DbContext
    {
        public clsWeflyDbContext(DbContextOptions<clsWeflyDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<clsBookingDetails>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<clsBookingDetails>()
            .HasKey(c => c.paymentId);
        }

        public DbSet<clsCity> tblCities { get; set; }

        public DbSet<clsFlightRoute> tblFlightRoute { get; set; }

        public DbSet<clsFlightSchedule> tblFlightSchedule{ get; set; }

        public DbSet<clsPlaneSpecification> tblPlaneSpecification { get; set; }

        public DbSet<clsBookingDetails> tblBookingDetails { get; set; }

    }
}
