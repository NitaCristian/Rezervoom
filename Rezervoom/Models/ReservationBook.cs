using Rezervoom.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervoom.Models
{
    public class ReservationBook
    {
        private readonly List<Reservation> _reservations;

        public ReservationBook()
        {
            _reservations = new List<Reservation>();
        }

        public IEnumerable<Reservation> GetAllRezervations()
        {
            return _reservations;
        }

        public void AddRezervation(Reservation newRezervation)
        {
            foreach (Reservation existingRezervation in _reservations)
            {
                if (existingRezervation.Conflicts(newRezervation))
                {
                    throw new RezervationConflictException(existingRezervation, newRezervation);
                }
            }

            _reservations.Add(newRezervation);
        }
    }
}
