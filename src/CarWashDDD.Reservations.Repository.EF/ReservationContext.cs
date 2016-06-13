using CarWashDDD.Reservations.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashDDD.Reservations.Repository.EF
{
    public class ReservationContext : DbContext
    {
        public ReservationContext() : base("CarWashDDDContext")
        {

        }

        public DbSet<Consumer> Consumers { get; set; }
        public DbSet<OpeningHour> OpeningHours { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceProvider> ServiceProviders { get; set; }
    }
}
