using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tms.Model
{
        public class Booking
        {
            [Key]
            public int BookingID { get; set; }

            public DateTime BookingDate { get; set; }


            [MaxLength(20)]
            public string PassengerContact { get; set; } 

            [MaxLength(10)]
            public string Gender { get; set; }
            public string SeatNumber { get; set; }

        [MaxLength(50)]
            public string Status { get; set; }

            // Foreign Keys
            public string StaffID { get; set; }
            public string TripID { get; set; }



        [ForeignKey(nameof(StaffID))]
            public Staff Staff { get; set; }

        [ForeignKey(nameof(TripID))]
        public Trip Trip { get; set; }
    }

}
