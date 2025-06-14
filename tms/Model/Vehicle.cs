using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_info.Model
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string? PlateNumber { get; set; }
        public string? VehicleType { get; set; }
        public int Capacity { get; set; }
        public string? Status { get; set; }
    }
}
