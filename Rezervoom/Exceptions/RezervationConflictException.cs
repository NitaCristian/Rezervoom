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
        public Rezervation ExistingRezervation { get; }
        public Rezervation IncomingRezervation { get; }

        public RezervationConflictException(Rezervation existingRezervation, Rezervation incomingRezervation)
        {
            ExistingRezervation = existingRezervation;
            IncomingRezervation = incomingRezervation;
        }

        public RezervationConflictException(string message, Rezervation existingRezervation, Rezervation incomingRezervation) : base(message)
        {
            ExistingRezervation = existingRezervation;
            IncomingRezervation = incomingRezervation;
        }
        
        public RezervationConflictException(string message, Exception inner, Rezervation existingRezervation, Rezervation incomingRezervation) : base(message, inner)
        {
            ExistingRezervation = existingRezervation;
            IncomingRezervation = incomingRezervation;
        }

    }
}
