using CarWashDDD.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashDDD.Reservations.Domain
{
    public class Timetable : IAggregateRoot
    {
        public IList<ServiceProvider> ServiceProviders { get; private set; }
        public IList<Reservation> Reservations { get; private set; }

        public Timetable(IList<ServiceProvider> serviceProviders, IList<Reservation> reservations)
        {
            if (serviceProviders == null) serviceProviders = new List<ServiceProvider>();
            ServiceProviders = serviceProviders;
            if (reservations == null) reservations = new List<Reservation>();
            Reservations = reservations;
        }

        public AddReservationValidationResult AddReservation(Reservation reservation)
        {
            Reservation toBeInserted = null;
            string resultSummary = string.Empty;

            ReservationValidationSummary validationSummary = OkToAdd(reservation);
            if (validationSummary.OkToAdd)
            {
                toBeInserted = reservation;
                resultSummary = string.Format("Reservation ID {0} (insertion) successfully validated.{1}", reservation.Id);
            }
            else
            {
                resultSummary = string.Format("Reservation ID {0} (insertion) validation failed: {1}.",
                    reservation.Id, validationSummary.ReasonForValidationFailure);
            }

            AddReservationValidationResult validationResult = new AddReservationValidationResult(toBeInserted,  resultSummary);
            //TimetableChangedEventArgs args = new TimetableChangedEventArgs(validationResult);
            //DomainEventMediator.RaiseEvent(args);
            return validationResult;
        }

        private ReservationValidationSummary OkToAdd(Reservation reservation)
        {
            ReservationValidationSummary validationSummary = new ReservationValidationSummary(true, string.Empty);

            if (reservation.ReservedDate < DateTime.UtcNow)
            {
                validationSummary.SetValidationFailure("Reservation can't be saved in the past.");
            }

            return validationSummary;
        }
    }
}
