
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace tms.Model
{
    public class Trip
    {
        [Key]
        public string TripID { get; set; }
        public string VehicleID { get; set; }
        public string DriverID { get; set; }
        public string RouteID { get; set; }
        public DateTime DepatureTime { get; set; }
        public string status { get; set; }  

        public Vehicle? Vehicle { get; set; }
        public Driver? Driver { get; set; }
        public Route? Route { get; set; }

        public string RouteName => Route?.StartPoint + " → " + Route?.EndPoint;
    }
}
