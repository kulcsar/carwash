using CarWashDDD.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashDDD.Reservations.Domain
{
    public class Service : EntityBase<Guid>
    {
        public string Name { get; private set; }
        public int SlotCount { get; private set; }
        public Guid ServiceProviderId { get; set; }

        private Service() : base(Guid.NewGuid()) { }

        public Service(Guid guid, string name, int slotCount, Guid serviceProviderId) : base(guid)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("Service name");
            if (slotCount < 0) throw new ArgumentException("Service slotCount");
            if (serviceProviderId == null) throw new ArgumentNullException("Service serviceProviderId");

            Name = name;
            SlotCount = slotCount;
            ServiceProviderId = serviceProviderId;
        }
    }
}
