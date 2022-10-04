using Rezervoom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervoom.Exceptions
{
    public class RezervationConflictException : Exception
    {
        public Reservation ExistingRezervation { get; }
        public Reservation IncomingRezervation { get; }

        public RezervationConflictException(Reservation existingRezervation, Reservation incomingRezervation)
        {
            ExistingRezervation = existingRezervation;
            IncomingRezervation = incomingRezervation;
        }

        public RezervationConflictException(string message, Reservation existingRezervation, Reservation incomingRezervation) : base(message)
        {
            ExistingRezervation = existingRezervation;
            IncomingRezervation = incomingRezervation;
        }
        
        public RezervationConflictException(string message, Exception inner, Reservation existingRezervation, Reservation incomingRezervation) : base(message, inner)
        {
            ExistingRezervation = existingRezervation;
            IncomingRezervation = incomingRezervation;
        }

    }
}
