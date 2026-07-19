



//15

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using BE;
using DAL;

namespace BLL
{

    public class UserBLL
    {
        private readonly UserDAL dal = new UserDAL();

        public bool AdminExists() => dal.IsAdminExists();




        public void RegisterUser(string fullName, string username, string password, string role)
        {
            if (IsUsernameDuplicate(username))
                throw new Exception("نام کاربری قبلا ثبت شده است.");

            var hashedPassword = HashPassword(password);
            var user = new User
            {
                FullName = fullName,
                Username = username,
                PasswordHash = hashedPassword,
                Role = role,
                RegisterDate = DateTime.Now
            };

            dal.InsertUser(user);
        }

        private string HashPassword(string password)
        {
            using (var sha = System.Security.Cryptography.SHA256.Create())
            {
                var bytes = System.Text.Encoding.UTF8.GetBytes(password);
                var hash = sha.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }





        public User Login(string username, string password)
        {
            var hashedPassword = HashPassword(password);
            return dal.GetUserByCredentials(username, hashedPassword);
        }

        public bool IsUsernameDuplicate(string username)
        {
            return dal.IsUsernameExists(username);
        }

        //

        public List<User> GetAll()
        {
            using (var db = new karconan())
            {
                return db.Users.ToList();
            }
        }

        public bool Delete(int id)
        {
            using (var db = new karconan())
            {
                var user = db.Users.Find(id);
                if (user != null && user.Role != "Admin")
                {
                    db.Users.Remove(user);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }
    }








    public class EmployeeBLL
    {
        private readonly EmployeeDAL dal = new EmployeeDAL();

        public bool IsNationalCodeExists(string nationalCode)
        {
            return dal.IsNationalCodeExists(nationalCode);
        }

        public void Add(Employee emp)
        {
            if (IsNationalCodeExists(emp.NationalCode))
                throw new Exception("کد ملی تکراری است.");

            dal.Add(emp);
        }

        // متدهای دیگر به همین شکل...
        //

        private readonly EmployeeDAL _employeeDAL;

        public EmployeeBLL()
        {
            _employeeDAL = new EmployeeDAL();
        }



    }


    public class EmployeeManager
    {
        private readonly EmployeeDAL _dal = new EmployeeDAL();



        private readonly karconan _context = new karconan();

    }
    public class AttendanceManager
    {
        private readonly AttendanceDAL _dal = new AttendanceDAL();
        //24-7-1404
        private readonly TimeSpan WORK_START = new TimeSpan(6, 00, 0);
        private readonly TimeSpan WORK_END = new TimeSpan(23, 59, 0);
        private readonly TimeSpan MIN_EXIT_TIME = new TimeSpan(14, 15, 0);
        private readonly TimeSpan MIN_HOURLY_LEAVE = new TimeSpan(1, 0, 0);


        //
        public string RegisterMission(int empId, DateTime fromDate, DateTime toDate)
        {
       

            // 1. اعتبارسنجی محدوده تاریخ
            if (!ValidateDateRange(fromDate, toDate))
                return "محدوده تاریخ نامعتبر است";

            // 2. بررسی تداخل با مرخصی روزانه و مأموریت‌های موجود
            StringBuilder errors = new StringBuilder();


            if (errors.Length > 0)
            {
                return $"امکان ثبت مأموریت وجود ندارد:\n{errors}";
            }

            // 3. ثبت مأموریت برای هر روز
            try
            {
              

                return null; // موفق
            }
            catch (Exception ex)
            {
                return $"خطا در ثبت مأموریت: {ex.Message}";
            }
        }

        private bool ValidateDateRange(DateTime fromDate, DateTime toDate)
        {
            return fromDate <= toDate &&
                   (toDate - fromDate).Days <= 365; // حداکثر 1 سال
        }


        //



      
        private string ConvertToShamsi(DateTime miladiDate)
        {
            try
            {
                PersianCalendar pc = new PersianCalendar();
                return $"{pc.GetYear(miladiDate)}/{pc.GetMonth(miladiDate):00}/{pc.GetDayOfMonth(miladiDate):00}";
            }
            catch
            {
                return "تاریخ نامعتبر";
            }
        }

        private DateTime ConvertShamsiToMiladi(string shamsiDate)
        {
            try
            {
                PersianCalendar pc = new PersianCalendar();
                var parts = shamsiDate.Split('/');

                return pc.ToDateTime(
                    int.Parse(parts[0]),
                    int.Parse(parts[1]),
                    int.Parse(parts[2]),
                    0, 0, 0, 0
                );
            }
            catch
            {
                throw new ArgumentException($"فرمت تاریخ نامعتبر: {shamsiDate}");
            }
        }
        private IEnumerable<DateTime> EachDay(DateTime from, DateTime to)
        {
            for (var day = from.Date; day <= to.Date; day = day.AddDays(1))
                yield return day;
        }


    }



   

    public class AttendanceReport
    {
        public DateTime Date { get; set; }
        public string DateString { get; set; } // نمایش شمسی
        public DateTime? EntryTime { get; set; }
        public DateTime? ExitTime { get; set; }
        public TimeSpan Delay { get; set; }
        public TimeSpan Earliness { get; set; }
        public TimeSpan? Overtime { get; set; }
        public TimeSpan? HourlyLeave { get; set; }
        public bool HasDailyLeave { get; set; }
        public bool IsOnMission { get; set; } // جدید: وضعیت مأموریت
        public string Status { get; set; }

        // ویژگی‌های نمایشی
        public string EntryTimeDisplay => EntryTime?.ToString("HH:mm") ?? "-";
        public string ExitTimeDisplay => ExitTime?.ToString("HH:mm") ?? "-";
        public string OvertimeDisplay => Overtime?.ToString(@"hh\:mm") ?? "-";
        public string HourlyLeaveDisplay => HourlyLeave?.ToString(@"hh\:mm") ?? "-";
        public string MissionDisplay => IsOnMission ? "🏢" : "✖️";

    }
}
//15


