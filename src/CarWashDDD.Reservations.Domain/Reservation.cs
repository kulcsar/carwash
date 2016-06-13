using CarWashDDD.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashDDD.Reservations.Domain
{
    public class Reservation : EntityBase<Guid>
    {
        public DateTime ReservedDate { get; private set; }
        public Consumer Consumer { get; private set; }
        public string PlateNumber { get; private set; }
        public Service Service { get; private set; }
        public string Comment { get; private set; }

        private Reservation() : base(Guid.NewGuid()) { }

        public Reservation(Guid guid, DateTime reservedDateUtc, Consumer consumer, string plateNumber, Service service, string comment) : base(guid)
        {
            if (reservedDateUtc == DateTime.MinValue) throw new ArgumentException("Reservation reservedDate");
            if (consumer == null) throw new ArgumentNullException("Reservation consumer");
            if (string.IsNullOrEmpty(plateNumber)) throw new ArgumentNullException("Reservation plateNumber");
            if (service == null) throw new ArgumentNullException("Reservation service");

            ReservedDate = reservedDateUtc;
            Consumer = consumer;
            Consumer.SetPlateNumber(plateNumber);
            PlateNumber = plateNumber;
            Service = service;
            Comment = comment;
        }

        //private void RaiseIfDefaultGuid(Guid guid)
        //{
        //    if (guid == default(Guid))
        //    {
        //        throw new ArgumentException("Default GUID not acceptable");
        //    }
        //}
    }
}
