using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Seat_info.Model
{
    public class Seat
    {
        public int SeatId { get; set; }
        public string? VehicleID { get; set; }
        public string? SeatNumber { get; set; }
        public string? SeatType { get; set; }
        public string? seatStatus { get; set; }
    }
}