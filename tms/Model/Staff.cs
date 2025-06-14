

using System.ComponentModel.DataAnnotations;

namespace tms.Model
{
    public class Staff
    {
        [Key]
        public int StaffId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string BirthDate { get; set; }
        public string Address { get; set; }
        public string Personal_PhoneNumber { get; set; }
        public string Contact_PhoneNumber { get; set; }
        public string Hired_Date { get; set; }
        public decimal Salary { get; set; }
        public bool IsStopWorking { get; set; }
    }
}
