
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using tms.Data;
using tms.Model;

namespace Staff_info.Repository
{
    public class StaffRepository
    {
        public List<Staff> GetAll()
        {
            using var context = new AppDbContext();

            return context.Staffs.ToList();
        }

        public List<Staff> GetDriverStaff()
        {
            using var context = new AppDbContext();

            return context.Staffs
             .Where(s => s.position.ToLower() == "driver")
             .ToList();

        }
        public bool Add(Staff staff)
        {
            using var context = new AppDbContext();

            var parameters = new[]
            {
        new SqlParameter("@StaffId", staff.StaffId),
        new SqlParameter("@Name", staff.Name),
        new SqlParameter("@PersonalPhone", staff.Personal_PhoneNumber),
        new SqlParameter("@ContactPhone", staff.Contact_PhoneNumber),
        new SqlParameter("@Gender", staff.Gender),
        new SqlParameter("@BirthDate", staff.BirthDate),
        new SqlParameter("@Address", staff.Address),
        new SqlParameter("@Position", staff.position),
        new SqlParameter("@Hired_Date", staff.Hired_Date),
        new SqlParameter("@Salary", staff.Salary),
        new SqlParameter("@IsStopWorking", staff.IsStopWorking),
        new SqlParameter
        {
            ParameterName = "@Photo",
            SqlDbType = SqlDbType.VarBinary,
            Value = (object?)staff.Photo ?? DBNull.Value
        }
    };

            return context.Database.ExecuteSqlRaw(
                "EXEC AddStaff @StaffId, @Name, @PersonalPhone, @ContactPhone, @Gender, @BirthDate, @Address, @Position, @Hired_Date, @Salary, @IsStopWorking, @Photo",
                parameters) > 0;
        }

        public bool Update(Staff staff)
        {
            using var context = new AppDbContext();

            var parameters = new[]
            {
        new SqlParameter("@StaffId", staff.StaffId),
        new SqlParameter("@Name", staff.Name),
        new SqlParameter("@PersonalPhone", staff.Personal_PhoneNumber),
        new SqlParameter("@ContactPhone", staff.Contact_PhoneNumber),
        new SqlParameter("@Gender", staff.Gender),
        new SqlParameter("@Address", staff.Address),
        new SqlParameter("@BirthDate", staff.BirthDate),
        new SqlParameter("@Hired_Date", staff.Hired_Date),
        new SqlParameter("@Position", staff.position),
        new SqlParameter("@Salary", staff.Salary),
        new SqlParameter("@IsStopWorking", staff.IsStopWorking),
        new SqlParameter
            {
                ParameterName = "@Photo",
                SqlDbType = SqlDbType.VarBinary,
                Value = (object?)staff.Photo ?? DBNull.Value
            }
        };

            return context.Database.ExecuteSqlRaw(
                "EXEC UpdateStaff @StaffId, @Name, @PersonalPhone, @ContactPhone, @Gender, @Address, @BirthDate, @Hired_Date, @Position, @Salary, @IsStopWorking, @Photo",
                parameters) > 0;
        }

        public void Delete(string staffId)
        {
            using var context = new AppDbContext();
            var staff = context.Staffs.FirstOrDefault(s => s.StaffId == staffId);
            if (staff != null)
            {
                context.Staffs.Remove(staff);
                context.SaveChanges();
            }
        }


        public List<Staff> Search(string keyword)
        {
            using var context = new AppDbContext();

            var parameter = new SqlParameter("@Keyword", keyword);

            return context.Staffs
                .FromSqlRaw("EXEC SearchStaff @Keyword", parameter)
                .ToList();
        }

     
    }
}
