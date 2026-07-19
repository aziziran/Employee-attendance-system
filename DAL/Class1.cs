




using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using BE;

namespace DAL
{
    public class karconan : DbContext
    {
        public karconan() : base("constr") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<SystemTimeLog> SystemTimeLogs { get; set; }
    }

    public class UserDAL
    {
        private readonly karconan db = new karconan();

        public bool IsAdminExists()
        {
            return db.Users.Any(u => u.Role == "Admin");
        }

        public void InsertUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public User GetUserByCredentials(string username, string passwordHash)
        {
            return db.Users.FirstOrDefault(u => u.Username == username && u.PasswordHash == passwordHash);
        }

        public bool IsUsernameExists(string username)
        {
            return db.Users.Any(u => u.Username == username);
        }



    }

    public class EmployeeDAL
    {
        private readonly karconan _context;

        public EmployeeDAL()
        {
            _context = new karconan();
        }

        //111111
        public Employee GetEmployeeById(int id)
        {
            using (var db = new karconan())
            {
                return db.Employees
                       .AsNoTracking() // برای بهبود عملکرد

                       .FirstOrDefault(e => e.Id == id);
            }
        }

        public bool IsNationalCodeExists(string nationalCode)
        {
            return _context.Employees.Any(e => e.NationalCode == nationalCode);
        }

        //11
        public void Add(Employee emp)
        {
            _context.Employees.Add(emp);
            _context.SaveChanges();
        }




    }



    public class AttendanceDAL
    {
        private readonly karconan _db = new karconan();

        public bool ValidateDateRange(DateTime fromDate, DateTime toDate)
        {
            // محدوده معقول برای سیستم‌های ایرانی (حدود 1400-1500 شمسی)
            var minDate = new DateTime(2021, 3, 21);
            var maxDate = new DateTime(2122, 3, 21);

            return fromDate >= minDate && toDate <= maxDate;
        }

    }
}

//15
