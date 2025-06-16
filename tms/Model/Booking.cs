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

            public int SeatNumber { get; set; }

            [MaxLength(50)]
            public string Status { get; set; }

            // Foreign Keys
            public string StaffID { get; set; }
            public int TripID { get; set; }


            [ForeignKey(nameof(StaffID))]
            public Staff Staff { get; set; }

            //[ForeignKey(nameof(TripID))]
            //public Trip Trip { get; set; }
        }

}
