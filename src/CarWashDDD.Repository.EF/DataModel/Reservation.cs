using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashDDD.Repository.EF.DataModel
{
    public class Reservation
    {
        public Guid Id { get; set; }
        public DateTime ReservedDateUtc { get; set; }
        public string ConsumerId { get; set; }
        public string PlateNumber { get; set; }
        public Guid ServiceId { get; set; }
        public string Comment { get; set; }
    }
}
