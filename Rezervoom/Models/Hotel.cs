using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervoom.Models
{
    public class Hotel
    {
        // Rezervations book that holds all the rezervations
        private readonly ReservationBook _rezervationBook;

        // Name of the hotel
        public string Name { get; }

        public Hotel(string name)
        {
            Name = name;  
            
            _rezervationBook = new ReservationBook();
        }

        /// <summary>
        /// Method to get all the rezervations
        /// </summary>
        /// <param name="username">Username of the user</param>
        /// <returns>List of rezervations</returns>
        public IEnumerable<Reservation> GetAllRezervations()
        {
            return _rezervationBook.GetAllRezervations();
        }

        /// <summary>
        /// Method to register a rezervation
        /// </summary>
        /// <param name="rezervation"></param>
        public void MakeRezervation(Reservation rezervation)
        {
            _rezervationBook.AddRezervation(rezervation);
        }
    }
}
