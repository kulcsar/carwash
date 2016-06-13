using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashDDD.Reservations.Domain
{
    //The abstract repository describes what data store operations the external callers will be able to perform on an aggregate root.
    public interface ITimetableRepository
    {
        void AddReservation(AddReservationValidationResult addReservationValidationResult);
        void DeleteReservation(Guid reservationId);
        Reservation GetReservationById(Guid reservationId);
        IList<Reservation> GetReservationsByTimeinterval(DateTime searchStartDateUtc, DateTime searchEndDateUtc);
    }
}
