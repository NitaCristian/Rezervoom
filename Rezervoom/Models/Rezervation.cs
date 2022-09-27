using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervoom.Models
{
    public class Rezervation
    {
        // A rezervation contains info about:

        // The ID of the room
        public RoomID RoomID { get; }
        // The user who makes the rezervation
        public string Username { get; }
        // The start date
        public DateTime StartTime { get; }
        // The end date
        public DateTime EndTime { get; }
        // Computed value of the length of the rezervation
        public TimeSpan Length => EndTime.Subtract(StartTime);

        public Rezervation(RoomID roomID, string username, DateTime startTime, DateTime endTime)
        {
            RoomID = roomID;
            Username = username;
            StartTime = startTime;
            EndTime = endTime;
        }

        // Method to check for conflicts between rezervations
        internal bool Conflicts(Rezervation rezervation)
        {
            if (rezervation.RoomID != RoomID) return false;

            return rezervation.StartTime < EndTime || 
                rezervation.EndTime > StartTime;
        }
    }
}
