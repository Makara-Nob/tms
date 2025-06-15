using System.ComponentModel.DataAnnotations;

namespace Passenger_info.Model
{
    public class Passenger
    {
        public int PassengerID { get; set; }
        public string PassengerName { get; set; }
        public string Gender { get; set; }
        public string PersonalNumber { get; set; }
        public string Email { get; set; }
        public int IsActive { get; set; }
    }
}