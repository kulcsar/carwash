using CarWashDDD.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashDDD.Reservations.Domain
{
    public class OpeningHour : EntityBase<Guid>
    {
        public int SlotCount { get; private set; }
        public Weekday Weekday { get; private set; }

        private OpeningHour() : base(Guid.NewGuid()) { }

        public OpeningHour(Guid guid, int slotCount, Weekday weekday) : base(guid)
        {
            if (slotCount < 0) throw new ArgumentException("OpeningHour slotCount");

            SlotCount = slotCount;
            Weekday = weekday;
        }
    }

    public enum Weekday
    {
        Monday, Tuesday, Wednesday, Thursday, Friday
    }
}
