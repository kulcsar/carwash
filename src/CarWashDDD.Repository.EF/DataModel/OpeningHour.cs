using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashDDD.Repository.EF.DataModel
{
    public class OpeningHour
    {
        public Guid Id { get; set; }        
        public int SlotCount { get; set; }
        public Weekday Weekday { get; set; }
        public Guid ServiceProviderId { get; set; }
    }
}
