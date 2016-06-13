using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashDDD.Reservations.Domain
{
    public class AddReservationValidationResult
    {
        public Reservation ToBeInserted { get; private set; }
        public string OperationResultSummary { get; private set; }
        public bool ValidationComplete { get; private set; }

        public AddReservationValidationResult(Reservation toBeInserted, string operationResultSummary)
        {
            ToBeInserted = toBeInserted;
            OperationResultSummary = operationResultSummary;
            ValidationComplete = !string.IsNullOrEmpty(operationResultSummary);
        }
    }
}
