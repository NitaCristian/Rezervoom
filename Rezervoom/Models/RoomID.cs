using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervoom.Models
{
    public class RoomID
    {
        // Floor the room is at
        public int FloorNumber { get; }
        // Number of the room
        public int RoomNumber { get; }

        public RoomID(int floorNumber, int roomNumber)
        {
            FloorNumber = floorNumber;
            RoomNumber = roomNumber;
        }

        public override string ToString()
        {
            return $"{FloorNumber}:{RoomNumber}";
        }
        
        // Method to check whether an object is equal to the current object
        public override bool Equals(object? obj)
        {
            return obj is RoomID roomID &&
                roomID.FloorNumber == FloorNumber &&
                roomID.RoomNumber == RoomNumber;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FloorNumber, RoomNumber);
        }

        public static bool operator ==(RoomID roomID1, RoomID roomID2)
        {
            if (roomID1 is null && roomID2 is null) return true;

            return roomID1 is not null && roomID1.Equals(roomID2);
        }

        public static bool operator !=(RoomID roomID1, RoomID roomID2)
        {
           return !(roomID1 == roomID2);
        }
    }
}
