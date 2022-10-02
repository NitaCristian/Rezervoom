using Rezervoom.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervoom.Models
{
    public class RezervationBook
    {
        // A list of all registrations
        private readonly List<Rezervation> _reservations;

        public RezervationBook()
        {
            _reservations = new List<Rezervation>();
        }

        // Method to get all the rezervations
        public IEnumerable<Rezervation> GetAllRezervations()
        {
            return _reservations;
        }

        // Method to add a rezervation to the list of all rezervations
        public void AddRezervation(Rezervation newRezervation)
        {
            foreach (Rezervation existingRezervation in _reservations)
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
