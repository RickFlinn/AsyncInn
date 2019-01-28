using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class HotelRoom
    {
        public int HotelLocationID { get; set; }
        public int RoomNumber { get; set; }
        public decimal RoomID { get; set; }
        public decimal Price { get; set; }
        public bool PetFriendly { get; set; }

        //Navigation properties
        public HotelLocation HotelLocation { get; set; }
        public Room Room { get; set; }
    }
}