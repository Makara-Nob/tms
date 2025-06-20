﻿
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

        public bool Add(Staff staff)
        {
            using var context = new AppDbContext();
            context.Staffs.Add(staff);
            return context.SaveChanges() > 0;
        }

        public List<Staff> Search(string keyword)
        {
            using var context = new AppDbContext();

            return context.Staffs
                .Where(s =>
                    s.Name.Contains(keyword) ||
                    s.Personal_PhoneNumber.Contains(keyword) ||
                    s.Contact_PhoneNumber.Contains(keyword) ||
                    s.Gender.Contains(keyword) ||
                    s.Address.Contains(keyword))
                .ToList();
        }
    
        public bool Update(Staff staff)
        {
            using var context = new AppDbContext();
            context.Staffs.Update(staff);
            return context.SaveChanges() > 0;
        }

        public void Delete(int staffId)
        {
            using var context = new AppDbContext();
            var staff = context.Staffs.FirstOrDefault(s => s.StaffId == staffId);
            if (staff != null)
            {
                context.Staffs.Remove(staff);
                context.SaveChanges();
            }
        }
    }
}
