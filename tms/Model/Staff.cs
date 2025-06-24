

using System.ComponentModel.DataAnnotations;

namespace tms.Model
{
    public class Staff
    {
        [Key]
        public string StaffId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public byte[]? Photo { get; set; }

        public string Address { get; set; }
        public string Personal_PhoneNumber { get; set; }
        public string Contact_PhoneNumber { get; set; }
        public string position { get; set; }
        public DateTime Hired_Date { get; set; }
        public decimal Salary { get; set; }
        public bool IsStopWorking { get; set; }

       
    }
}
