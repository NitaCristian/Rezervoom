using Rezervoom.Exceptions;
using Rezervoom.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Rezervoom
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // Create a new Hotel object
            Hotel hotel = new Hotel("Cristian Suites");

            // Add some rezervations and check for conflicts
            try
            {
                hotel.MakeRezervation(new Rezervation(
               new RoomID(1, 3),
               "Cristian",
               new DateTime(2000, 1, 1),
               new DateTime(2000, 1, 3)
               ));

                hotel.MakeRezervation(new Rezervation(
               new RoomID(1, 3),
               "Cristian",
               new DateTime(2000, 1, 1),
               new DateTime(2000, 1, 4)
               ));
            }
            catch (RezervationConflictException ex)
            {

            }

            // Get all the rezervations
            var rezervations = hotel.GetAllRezervations();

            base.OnStartup(e);
        }
    }
}
