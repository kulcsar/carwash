using CarWashDDD.Reservations.Domain;
using CarWashDDD.Reservations.Repository.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashDDD.DatabaseTester
{
    public class ReservationContextService
    {
        public void TestReservationContext()
        {
            ReservationContext reservationContext = new ReservationContext();
            List<Service> services = reservationContext.Services.ToList();
        }
    }
}
