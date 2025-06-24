using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tms.projection
{
    public class TripDetail
    {
        public string TripID { get; set; }
        public string Type { get; set; }          
        public string DriverName { get; set; }    
        public string RouteName { get; set; }     
        public DateTime DepartureTime { get; set; }
        public string status { get; set; }
    }
}
