using CarWashDDD.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashDDD.Reservations.Domain
{
    public class Consumer : EntityBase<string>
    {
        public string Name { get; private set; }
        public string PlateNumber { get; private set; }

        private Consumer() : base(string.Empty) { }

        public Consumer(string id, string name, string plateNumber) : base(id)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("Consumer name");
            if (string.IsNullOrEmpty(plateNumber)) throw new ArgumentNullException("Consumer plateNumber");

            Name = name;
            PlateNumber = plateNumber;
        }

        public Consumer SetPlateNumber(string plateNumber)
        {
            return new Consumer(Id, Name, plateNumber);
        }
    }
}
