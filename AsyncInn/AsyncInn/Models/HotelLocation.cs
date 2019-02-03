using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class HotelLocation
    {
        public int ID { get; set; }

        [Required(ErrorMessage="Please provide a name for this location.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please provide an address.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please provide a phone number for this location.")]
        public string Phone { get; set; }


        // Navigation Properties
        public ICollection<HotelRoom> Rooms { get; set; }

    }
}
