using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashDDD.Repository.EF.DataModel
{
    public class Service
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int SlotCount { get; set; }
        public Guid ServiceProviderId { get; set; }
    }
}
