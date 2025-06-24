    using tms.Model;
    namespace Seat_info.Model
    {
        public class Seat
        {
            public int SeatId { get; set; }
            public string? VehicleID { get; set; }
            public string? SeatNumber { get; set; }
            public string? SeatType { get; set; }
            public string? seatStatus { get; set; }

            public Vehicle? Vehicle { get; set; }


        // Additional properties for UI-based management
        public int RowNumber { get; set; }
        public int SeatPosition { get; set; } // Position within row (1, 2, 3, etc.)
        public char SeatLetter { get; set; } // A, B, C, D, etc.
        public decimal? Price { get; set; } // Different prices for different seat types
        public bool IsWindowSeat { get; set; }
        public bool IsAisleSeat { get; set; }
        public string? SeatFeatures { get; set; } // Extra legroom, reclining, etc.
        public DateTime? LastUpdated { get; set; }
        public string? UpdatedBy { get; set; }
    }
        public enum SeatStatus
        {
            Available,
            Selected,   
            Occupied,
            Maintenance,
            Reserved
        }

        public enum SeatType
        {
            Economy,
            Business,
            FirstClass,
            Premium
        }
    }