using CarWashDDD.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashDDD.Reservations.Domain
{
    public class ServiceProvider : EntityBase<Guid>
    {
        public string Name { get; private set; }
        public IList<Service> Services { get; private set; }
        public IList<OpeningHour> OpeningHours { get; private set; }

        private ServiceProvider() : base(Guid.NewGuid()) { }

        public ServiceProvider(Guid guid, string name, IList<Service> services, IList<OpeningHour> openingHours) : base(guid)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("ServiceProvider name");
            if (services == null || services.Count() == 0) throw new ArgumentException("ServiceProvider services");
            if (openingHours == null || openingHours.Count() == 0) throw new ArgumentException("ServiceProvider openingHours");

            Name = name;
            Services = services;
            OpeningHours = openingHours;
        }
    }
}
