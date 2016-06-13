using CarWashDDD.Repository.EF.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashDDD.Repository.EF
{
    public class CarWashDDDContext : DbContext
    {
        public CarWashDDDContext() : base("CarWashDDDContext")
        {

        }

        public DbSet<Consumer> Consumers { get; set; }
        public DbSet<OpeningHour> OpeningHours { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceProvider> ServiceProviders { get; set; }
    }
}
