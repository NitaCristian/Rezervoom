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
        private readonly RezervationBook _rezervationBook;

        // Name of the hotel
        public string Name { get; }

        public Hotel(string name)
        {
            Name = name;  
            
            _rezervationBook = new RezervationBook();
        }

        /// <summary>
        /// Method to get all the rezervations made by a user
        /// </summary>
        /// <param name="username">Username of the user</param>
        /// <returns>List of rezervations</returns>
        public IEnumerable<Rezervation> GetRezervationsForUser(string username)
        {
            return _rezervationBook.GetRezervationsForUser(username);
        }

        /// <summary>
        /// Method to register a rezervation
        /// </summary>
        /// <param name="rezervation"></param>
        public void MakeRezervation(Rezervation rezervation)
        {
            _rezervationBook.AddRezervation(rezervation);
        }
    }
}
