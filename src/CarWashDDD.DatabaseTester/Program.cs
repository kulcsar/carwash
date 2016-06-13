using CarWashDDD.Repository.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashDDD.DatabaseTester
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarWashDDDContext context = new CarWashDDDContext();
            //var services = context.Services.ToList();

            ReservationContextService domainService = new ReservationContextService();
            domainService.TestReservationContext();
        }
    }
}
