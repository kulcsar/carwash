using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashDDD.Reservations.Domain
{
    public class ReservationValidationSummary
    {
        public bool OkToAdd { get; private set; }
        public string ReasonForValidationFailure { get; private set; }

        public ReservationValidationSummary(bool okToAdd, string reasonForValidationFailure)
        {
            OkToAdd = okToAdd;
            ReasonForValidationFailure = reasonForValidationFailure;
        }

        public ReservationValidationSummary SetValidationFailure(string reasonForValidationFailure)
        {
            if (string.IsNullOrEmpty(reasonForValidationFailure)) throw new ArgumentException("SetValidationFailure reasonForValidationFailure");

            return new ReservationValidationSummary(false, reasonForValidationFailure);
        }
    }
}
