using CarWashDDD.Reservations.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashDDD.Reservations.Repository.EF.Repositories
{
    public class TimetableRepository : ITimetableRepository
    {
        public void AddReservation(AddReservationValidationResult addReservationValidationResult)
        {
            ReservationContext context = new ReservationContext();

            if (addReservationValidationResult.ValidationComplete)
            {
                context.Entry<Reservation>(addReservationValidationResult.ToBeInserted).State = System.Data.Entity.EntityState.Added;
            }
            else
            {
                throw new InvalidOperationException("Validation is not complete. You have to call the AddReservation method of the Timetable class first.");
            }           

            context.SaveChanges();
        }

        public void DeleteReservation(Guid reservationId)
        {
            ReservationContext context = new ReservationContext();

            Reservation reservation = (from r in context.Reservations where r.Id == reservationId select r).FirstOrDefault();
            if (reservation == null) throw new ArgumentException(string.Format("There's no reservation by ID {0}", reservationId));
            context.Entry<Reservation>(reservation).State = System.Data.Entity.EntityState.Deleted;

            context.SaveChanges();
        }

        public Reservation GetReservationById(Guid reservationId)
        {
            ReservationContext context = new ReservationContext();

            Reservation reservation = (from r in context.Reservations where r.Id == reservationId select r).FirstOrDefault();
            if (reservation == null) throw new ArgumentException(string.Format("There's no reservation by ID {0}", reservationId));

            return reservation;
        }

        public IList<Reservation> GetReservationsByTimeinterval(DateTime searchStartDateUtc, DateTime searchEndDateUtc)
        {
            ReservationContext context = new ReservationContext();

            IList<Reservation> reservationsInSearchPeriod =
                (from r in context.Reservations
                 where r.ReservedDate >= searchStartDateUtc
                        && r.ReservedDate <= searchEndDateUtc
                 select r).ToList();

            return reservationsInSearchPeriod;
        }
    }
}
