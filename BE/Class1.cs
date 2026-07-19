


using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }
        public DateTime RegisterDate { get; set; }
    }

    //1111
    public class Employee
    {
        public int Id { get; set; }
        [Required] public string FirstName { get; set; }
        [Required] public string LastName { get; set; }
        public string FatherName { get; set; }
        [Required] public string NationalCode { get; set; }
        [Required] public byte[] Picture { get; set; }

        public string FullName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(FirstName) && string.IsNullOrWhiteSpace(LastName))
                    return "نام نامشخص";
                return $"{FirstName?.Trim()} {LastName?.Trim()}".Trim();
            }
        }

    }

    //1111
    public enum AttendanceType
    {
        Entry,
        Exit,
        Delay,
        EarlyLeave,
        DailyLeave,
        HourlyLeave,
        OvertimeEntry,
        OvertimeExit,
        AutoEntry, // جدید
        HourlyLeaveExit, // جدید برای خروج موقت
        Mission // جدید

    }
    //111
    public class Attendance
    {
        [Key] public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime? EntryTime { get; set; }
        public DateTime? ExitTime { get; set; }
        public TimeSpan Delay { get; set; }
        public TimeSpan Earliness { get; set; }
        public TimeSpan Overtime { get; set; }
        public TimeSpan? Duration { get; set; }
        public AttendanceType Type { get; set; }
        public bool HasDailyLeave { get; set; }
        public bool IsAbsent { get; set; }
        [ForeignKey("Employee")] public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public string Status { get; set; }
        public bool IsHourlyLeaveExit { get; set; } // افزودن فیلد جدید برای خروج مرخصی ساعتی


        [ForeignKey("OvertimeEntry")]
        public int? OvertimeEntryId { get; set; } // ارتباط با رکورد شروع

        public virtual Attendance OvertimeEntry { get; set; }
        public bool IsOnMission { get; set; } // فیلد جدید

    }


    //111
    public class SystemTimeLog
    {
        public int Id { get; set; }
        public DateTime LastValidDateTime { get; set; }
    }
}

//15