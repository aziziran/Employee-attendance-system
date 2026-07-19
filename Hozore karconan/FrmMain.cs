


using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using BLL;
using BE;
using System.Collections.Generic;
using System.Diagnostics;

using System.Drawing.Printing;




namespace Hozore_karconan
{
    public partial class FrmMain : Form
    {
        private readonly AttendanceManager _attendanceManager = new AttendanceManager();
        private readonly EmployeeManager _employeeManager = new EmployeeManager();
        private Timer _autoAbsenceTimer;

        public FrmMain()
        {
            InitializeComponent();
            InitializeForm();

            //SetupAutoEntryTimer();

            // مقداردهی اولیه TextBox
            textBox1.Text = "0";
            textBox1.ReadOnly = true;

        }

        //11
       



        //11111


        private void InitializeForm()
        {
            try
            {
                //SetupAutoAbsenceTimer();
                SetDefaultDates();
                ConfigureDataGridView();
                //LoadEmployees();

                // تنظیمات جدید
                button5.Text = "افزودن روز مأموریت";
                button6.Text = "کاهش روز مأموریت";
                button7.Visible = true; // دکمه جدید برای ثبت نهایی
                button7.Text = "ثبت مأموریت";

            }
            catch (Exception ex)
            {
                ShowErrorMessage("خطا در راه‌اندازی فرم", ex);
            }
        }

        private void SetDefaultDates()
        {
            var today = DateTime.Now;
            dateTimePickerX1.Text = ConvertMiladiToShamsi(today);
            dateTimePickerX2.Text = ConvertMiladiToShamsi(today);
            //dateTimePickerX3.Text = ConvertMiladiToShamsi(today);
        }

        private void ConfigureDataGridView()
        {
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.ReadOnly = true;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.AllowUserToAddRows = false;
            dgvReport.AllowUserToDeleteRows = false;
            dgvReport.RowHeadersVisible = false;
        }

        //private void LoadEmployees()
        //{
        //    try
        //    {
        //        var employees = _employeeManager.GetAllEmployees()
        //            .OrderBy(e => e.FullName)
        //            .ToList();

        //        comboBox1.DataSource = employees;

        //        //24-7-1404  FullName
        //        comboBox1.DisplayMember = "NationalCode";
        //        comboBox1.ValueMember = "Id";
        //        comboBox1.SelectedIndex = -1;
        //    }
        //    catch (Exception ex)
        //    {
        //        ShowErrorMessage("خطا در بارگذاری لیست کارمندان", ex);
        //    }
        //}

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (comboBox1.SelectedValue != null && comboBox1.SelectedValue is int)
        //    {
        //        int empId = (int)comboBox1.SelectedValue;
        //        button4.Enabled = _attendanceManager.HasOpenHourlyLeave(empId, DateTime.Today);
        //    }
        //    else
        //    {
        //        button4.Enabled = false;
        //    }
        //}        // در فرم اصلی
        //private void SetupAutoEntryTimer()
        //{
        //    Timer timer = new Timer();
        //    timer.Interval = 60000; // 1 دقیقه
        //    timer.Tick += (s, e) =>
        //    {
        //        if (DateTime.Now.TimeOfDay >= new TimeSpan(14, 15, 0) &&
        //            DateTime.Now.TimeOfDay < new TimeSpan(14, 16, 0))
        //        {
        //            try
        //            {
        //                _attendanceManager.RegisterAutoEntries(); // بدون پارامتر
        //                RefreshDataGrid(); // به‌روزرسانی گرید
        //            }
        //            catch (Exception ex)
        //            {
        //                Debug.WriteLine($"خطا در ثبت خودکار: {ex.Message}");
        //            }
        //        }
        //    };
        //    timer.Start();
        //}

        //private void SetupAutoAbsenceTimer()
        //{
        //    _autoAbsenceTimer = new Timer
        //    {
        //        Interval = 60000 // هر 1 دقیقه
        //    };

        //    _autoAbsenceTimer.Tick += (s, e) =>
        //    {
        //        try
        //        {
        //            if (DateTime.Now.TimeOfDay >= new TimeSpan(14, 30, 0))
        //            {
        //                _attendanceManager.RegisterAutoAbsences();
        //                _autoAbsenceTimer.Stop();
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            _autoAbsenceTimer.Stop();
        //            ShowErrorMessage("خطا در ثبت غیبت خودکار", ex);
        //        }
        //    };

        //    _autoAbsenceTimer.Start();
        //}


        private DateTime ConvertShamsiToMiladi(string shamsiDate)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(shamsiDate) || shamsiDate.Split('/').Length != 3)
                    return DateTime.Today;

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
                return DateTime.Today;
            }
        }

     

        private void ShowErrorMessage(string message, Exception ex = null)
        {
            string errorMessage = message;

            if (ex != null)
            {
                errorMessage += $"\n\nجزئیات خطا: {ex.Message}";

                if (ex.InnerException != null)
                {
                    errorMessage += $"\n\nجزئیات داخلی: {ex.InnerException.Message}";
                }
            }

            MessageBox.Show(errorMessage, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message, "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidateEmployeeSelection()
        {
            if (comboBox1.SelectedValue == null)
            {
                ShowErrorMessage("کارمندی با این کد ملی وجود ندارد");
                comboBox1.Focus();
                return false;
            }
            return true;
        }

        private bool ValidateDateRange(DateTime fromDate, DateTime toDate)
        {
            if (fromDate > toDate)
            {
                ShowErrorMessage("تاریخ شروع نمی‌تواند بعد از تاریخ پایان باشد");
                dateTimePickerX1.Focus();
                return false;
            }
            return true;
        }


        //private void RefreshDataGrid()
        //{
        //    try
        //    {
        //        DateTime fromDate = ConvertShamsiToMiladi(dateTimePickerX1.Text);
        //        DateTime toDate = ConvertShamsiToMiladi(dateTimePickerX2.Text);
        //        int empId = (int)comboBox1.SelectedValue;

        //        var report = _attendanceManager.GetAttendanceReport(empId, fromDate, toDate);
        //        DisplayReport(report);
        //    }
        //    catch (Exception ex)
        //    {
        //        ShowErrorMessage("خطا در به‌روزرسانی جدول", ex);
        //    }
        //}

        private void btnEntry_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnHourlyLeave_Click(object sender, EventArgs e)
        {

        }

        private void btnOvertime_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {


        }





        // در فرم گزارش‌گیری (مثلاً FrmReport.cs)
        private DateTime GetSafeDateTimeValue(DateTimePicker picker)
        {
            try
            {
                // بررسی وجود کنترل
                if (picker == null || picker.IsDisposed)
                {
                    MessageBox.Show("کنترل تاریخ معتبر نیست");
                    return DateTime.Today;
                }

                // بررسی آیا کنترل مقدار دارد
                if (picker.Value == null)
                {
                    MessageBox.Show("لطفاً تاریخ را انتخاب کنید");
                    return DateTime.Today;
                }

                return picker.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در خواندن تاریخ: {ex.Message}");
                return DateTime.Today;
            }
        }


        // استفاده:


        //private void LoadReportData()
        //{
        //    try
        //    {
        //        // دریافت گزارش از لایه BLL
        //        var report = _attendanceManager.GetAttendanceReport(
        //            (int)comboBox1.SelectedValue,
        //          ConvertShamsiToMiladi(dateTimePickerX1.Text),
        //           ConvertShamsiToMiladi(dateTimePickerX2.Text)

        //        );

        //        // تنظیم منبع داده برای DataGridView
        //        dgvReport.DataSource = report.Select(r => new
        //        {
        //            تاریخ = r.Date.ToString("yyyy/MM/dd"),
        //            ورود = r.EntryTime?.ToString("HH:mm") ?? "-",
        //            خروج = r.ExitTime?.ToString("HH:mm") ?? "-",
        //            اضافه_کاری = r.OvertimeDisplay,
        //            مرخصی_ساعتی = r.HourlyLeaveDisplay,
        //            وضعیت = r.Status
        //        }).ToList();

         
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"خطا در بارگذاری گزارش: {ex.Message}");
        //    }
        //}




        private void DisplayReport(IEnumerable<AttendanceReport> report)
        {
            try
            {
                DataTable dt = new DataTable();
                // ایجاد ستون‌ها
                dt.Columns.Add("تاریخ", typeof(string));
                dt.Columns.Add("ورود", typeof(string));
                dt.Columns.Add("خروج", typeof(string));
             // dt.Columns.Add("تأخیر", typeof(string));
             //  dt.Columns.Add("تعجیل", typeof(string));
            //  dt.Columns.Add("اضافه کاری", typeof(string));
             // dt.Columns.Add("مرخصی روزانه", typeof(string));
                dt.Columns.Add("ماموریت", typeof(string));
                dt.Columns.Add("مرخصی ساعتی", typeof(string));
                dt.Columns.Add("وضعیت", typeof(string));

                // متغیرهای جمع کل
                TimeSpan totalOvertime = TimeSpan.Zero;
                int totalDailyLeaveDays = 0;
                int totalMissionDays = 0;
                TimeSpan totalHourlyLeave = TimeSpan.Zero;
                TimeSpan totalDelay = TimeSpan.Zero;
                TimeSpan totalEarliness = TimeSpan.Zero;

                // پر کردن داده‌ها و محاسبه جمع‌ها
                foreach (var item in report.OrderBy(r => r.Date))
                {
                    // محاسبات جمع کل
                    totalOvertime += item.Overtime ?? TimeSpan.Zero;
                    totalHourlyLeave += item.HourlyLeave ?? TimeSpan.Zero;
                    totalDelay += item.Delay;
                    totalEarliness += item.Earliness;
                    if (item.HasDailyLeave) totalDailyLeaveDays++;
                    if (item.IsOnMission) totalMissionDays++;

                    dt.Rows.Add(
                        ConvertMiladiToShamsi(item.Date),
                        item.EntryTimeDisplay,
                        item.ExitTimeDisplay,
                       // item.Delay.ToString(@"hh\:mm"),
                      //  item.Earliness.ToString(@"hh\:mm"),
                      //  item.OvertimeDisplay,
                      //  item.HasDailyLeave ? "✅" : "✖️",
                        item.MissionDisplay,
                        item.HourlyLeaveDisplay,
                        item.Status
                    );
                }

                // افزودن سطر جمع کل با تمام اطلاعات
                if (report.Any())
                {
                    DataRow totalRow = dt.NewRow();
                    totalRow["تاریخ"] = "جمع کل";
                   // totalRow["تأخیر"] = totalDelay.ToString(@"hh\:mm");
                  //  totalRow["تعجیل"] = totalEarliness.ToString(@"hh\:mm");
                  // totalRow["اضافه کاری"] = totalOvertime.ToString(@"hh\:mm");
                //  totalRow["مرخصی روزانه"] = $"{totalDailyLeaveDays} روز";
                    totalRow["ماموریت"] = $"{totalMissionDays} روز";
                    totalRow["مرخصی ساعتی"] = totalHourlyLeave.ToString(@"hh\:mm");
                    totalRow["وضعیت"] = "مجموع کل";

                    dt.Rows.Add(totalRow);
                }

                dgvReport.DataSource = dt;
                ApplyDataGridViewStyling();

                // استایل‌دهی ویژه به سطر مجموع
                if (dgvReport.Rows.Count > 0 && report.Any())
                {
                    int lastRowIndex = dgvReport.Rows.Count - 1;
                    DataGridViewRow lastRow = dgvReport.Rows[lastRowIndex];

                    // تغییر رنگ پس‌زمینه و فونت
                    lastRow.DefaultCellStyle.BackColor = Color.LightYellow;
                    lastRow.DefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);

                    // تراز وسط برای ستون‌ها
                    foreach (DataGridViewColumn column in dgvReport.Columns)
                    {
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage("خطا در نمایش گزارش", ex);
            }
        }


        // متد تبدیل تاریخ میلادی به شمسی
        private string ConvertMiladiToShamsi(DateTime miladiDate)
        {
            PersianCalendar pc = new PersianCalendar();
            return $"{pc.GetYear(miladiDate)}/{pc.GetMonth(miladiDate):00}/{pc.GetDayOfMonth(miladiDate):00}";
        }

        private void ApplyDataGridViewStyling()
        {
            dgvReport.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvReport.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvReport.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            dgvReport.AutoResizeColumns();
            dgvReport.Refresh();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // بارگذاری اولیه در متد InitializeForm انجام می‌شود

            textBox2.TextChanged += textBox2_TextChanged;

        }

        private void FrmMain_Load_1(object sender, EventArgs e)
        {
            InitializeCompanyEvents();

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (!ValidateEmployeeSelection()) return;

        //    try
        //    {
        //        int empId = (int)comboBox1.SelectedValue;
        //        string result = _attendanceManager.RegisterOvertimeEntry(empId, DateTime.Now);

        //        if (!string.IsNullOrEmpty(result))
        //            MessageBox.Show(result, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        else
        //            MessageBox.Show("شروع اضافه کاری با موفقیت ثبت شد", "موفقیت");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"خطا در ثبت شروع اضافه کاری: {ex.Message}", "خطا");
        //    }
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    if (!ValidateEmployeeSelection()) return;

        //    try
        //    {
        //        int empId = (int)comboBox1.SelectedValue;
        //        string result = _attendanceManager.RegisterOvertimeExit(empId, DateTime.Now);

        //        if (!string.IsNullOrEmpty(result))
        //            MessageBox.Show(result, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        else
        //            MessageBox.Show("پایان اضافه کاری با موفقیت ثبت شد", "موفقیت");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"خطا در ثبت پایان اضافه کاری: {ex.Message}", "خطا");
        //    }
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    if (!ValidateEmployeeSelection()) return;

        //    try
        //    {
        //        int empId = (int)comboBox1.SelectedValue;
        //        string error = _attendanceManager.RegisterDailyLeave(empId, DateTime.Today);

        //        if (!string.IsNullOrEmpty(error))
        //            ShowErrorMessage(error);
        //        else
        //            ShowSuccessMessage("مرخصی روزانه ثبت شد");
        //    }
        //    catch (Exception ex)
        //    {
        //        ShowErrorMessage("خطا در ثبت مرخصی روزانه", ex);
        //    }
        //}

       

      

       

      

        //private void btnOvertime_Click_1(object sender, EventArgs e)
        //{
        //    if (!ValidateEmployeeSelection()) return;

        //    try
        //    {
        //        int empId = (int)comboBox1.SelectedValue;
        //        string error = _attendanceManager.RegisterOvertimeEntry(empId, DateTime.Now);

        //        if (!string.IsNullOrEmpty(error))
        //            ShowErrorMessage(error);
        //        else
        //            ShowSuccessMessage("اضافه کاری با موفقیت ثبت شد");
        //    }
        //    catch (Exception ex)
        //    {
        //        ShowErrorMessage("خطا در ثبت اضافه کاری", ex);
        //    }
        //}

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    if (!ValidateEmployeeSelection()) return;

        //    try
        //    {
        //        int empId = (int)comboBox1.SelectedValue;
        //        string error = _attendanceManager.RegisterOvertimeEntry(empId, DateTime.Now);

        //        if (!string.IsNullOrEmpty(error))
        //            ShowErrorMessage(error);
        //        else
        //            ShowSuccessMessage("شروع اضافه کاری ثبت شد");
        //    }
        //    catch (Exception ex)
        //    {
        //        ShowErrorMessage("خطا در ثبت شروع اضافه کاری", ex);
        //    }
        //}

        //private void button2_Click_1(object sender, EventArgs e)
        //{
        //    if (!ValidateEmployeeSelection()) return;

        //    try
        //    {
        //        int empId = (int)comboBox1.SelectedValue;
        //        string error = _attendanceManager.RegisterOvertimeExit(empId, DateTime.Now);

        //        if (!string.IsNullOrEmpty(error))
        //            ShowErrorMessage(error);
        //        else
        //            ShowSuccessMessage("پایان اضافه کاری ثبت شد");
        //    }
        //    catch (Exception ex)
        //    {
        //        ShowErrorMessage("خطا در ثبت پایان اضافه کاری", ex);
        //    }
        //}

      


        private void button5_Click(object sender, EventArgs e)
        {
            int current = int.Parse(textBox1.Text);
            textBox1.Text = (current + 1).ToString();
        }

       

        private void button6_Click(object sender, EventArgs e)
        {
            int current = int.Parse(textBox1.Text);
            if (current > 0)
            {
                textBox1.Text = (current - 1).ToString();
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int count = int.Parse(textBox1.Text);
            button6.Enabled = count > 0;
            button7.Enabled = count > 0;
        }


        //چاپ



// کلاس برای مدیریت وضعیت چاپ
private class PrintState
    {
        public int CurrentRowIndex { get; set; } = 0;
        public List<DataGridViewRow> Rows { get; set; }
        public DataGridViewRow TotalRow { get; set; }
        public bool IsFirstPage { get; set; } = true;
            public int PageNumber { get; set; } = 1;

        }

        private PrintState currentPrintState;


        private float[] CalculateColumnWidths(PrintPageEventArgs e, DataGridView dgv, float totalWidth)
        {
            // 1. محاسبه مجموع عرض ستون‌ها در DataGridView
            float totalColumnWidth = 0;
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                totalColumnWidth += col.Width;
            }

            // 2. ایجاد آرایه عرض‌ها
            float[] widths = new float[dgv.Columns.Count];

            // 3. جلوگیری از تقسیم بر صفر
            if (totalColumnWidth <= 0)
            {
                // مقدار پیش‌فرض در صورت خطا
                float equalWidth = totalWidth / dgv.Columns.Count;
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    widths[i] = equalWidth;
                }
                return widths;
            }

            // 4. محاسبه عرض نسبی هر ستون
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                widths[i] = (dgv.Columns[i].Width / totalColumnWidth) * totalWidth;
            }

            return widths;
        }



        private void button8_Click(object sender, EventArgs e)
    {
        // بررسی انتخاب کارمند و داده‌ها
        if (comboBox1.SelectedItem == null)
        {
            MessageBox.Show("لطفاً کارمند را انتخاب کنید", "خطا",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (dgvReport.Rows.Count == 0 ||
            (dgvReport.Rows.Count == 1 && dgvReport.Rows[0].IsNewRow))
        {
            MessageBox.Show("داده‌ای برای چاپ وجود ندارد", "هشدار",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        try
        {
            // آماده‌سازی داده‌ها برای چاپ
            currentPrintState = new PrintState
            {
                Rows = dgvReport.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => !r.IsNewRow)
                    .ToList(),

                // ذخیره سطر مجموع اگر وجود دارد
                TotalRow = dgvReport.Rows.Count > 0 &&
                          dgvReport.Rows[dgvReport.Rows.Count - 1].Cells[0].Value?.ToString() == "جمع کل"
                    ? dgvReport.Rows[dgvReport.Rows.Count - 1]
                    : null
            };

            // ایجاد سند چاپ
            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.Landscape = true; // حالت لنداسکیپ
            pd.PrintPage += PrintReportPage;

            // نمایش پیش‌نمایش
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = pd;
            preview.WindowState = FormWindowState.Maximized;
            preview.ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"خطا در آماده‌سازی چاپ: {ex.Message}", "خطا",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

        //


     

        private void PrintReportPage(object sender, PrintPageEventArgs e)
        {
            // تنظیمات فونت
            Font titleFont = new Font("B Nazanin", 18, FontStyle.Bold);
            Font headerFont = new Font("B Nazanin", 14, FontStyle.Bold);
            Font contentFont = new Font("B Nazanin", 10);
            Font footerFont = new Font("B Nazanin", 10, FontStyle.Italic);

            // تنظیمات گرافیک
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            StringFormat rightAlign = new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Center };
            StringFormat centerAlign = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            StringFormat singleLineFormat = new StringFormat
            {
                Alignment = StringAlignment.Far,
                LineAlignment = StringAlignment.Center,
                FormatFlags = StringFormatFlags.NoWrap,
                Trimming = StringTrimming.EllipsisCharacter
            };

            float leftMargin = e.MarginBounds.Left;
            float rightMargin = e.MarginBounds.Right;
            float topMargin = e.MarginBounds.Top;
            float width = e.MarginBounds.Width;
            float y = topMargin;

            float[] columnWidths = CalculateColumnWidths(e, dgvReport, width);
            float headerHeight = headerFont.GetHeight(e.Graphics) * 1.5f;
            float rowHeight = contentFont.GetHeight(e.Graphics) * 1.5f;

            float footerHeight = footerFont.GetHeight(e.Graphics) + 20;
            float maxY = e.MarginBounds.Bottom - footerHeight;

            // چاپ عنوان و اطلاعات فقط در صفحه اول
            //if (currentPrintState.IsFirstPage)
            //{
            //    string title = "گزارش حضور و غیاب";
            //    e.Graphics.DrawString(title, titleFont, Brushes.DarkBlue, rightMargin, y, rightAlign);
            //    y += titleFont.GetHeight(e.Graphics) + 25;

            //    //Employee emp = (Employee)comboBox1.SelectedItem;
            //    string employeeInfo = $"کارمند: {emp.FullName} | کد ملی: {emp.NationalCode}";
            //    e.Graphics.DrawString(employeeInfo, headerFont, Brushes.Black, rightMargin, y, rightAlign);
            //    y += headerFont.GetHeight(e.Graphics) + 15;

            //    string dateRange = $"از تاریخ: {dateTimePickerX1.Text} تا {dateTimePickerX2.Text}";
            //    e.Graphics.DrawString(dateRange, headerFont, Brushes.Black, rightMargin, y, rightAlign);
            //    y += headerFont.GetHeight(e.Graphics) + 30;
            //}

            // چاپ هدر ستون‌ها
            {
                float x = e.MarginBounds.Right;
                for (int i = 0; i < dgvReport.Columns.Count; i++)
                {
                    RectangleF rect = new RectangleF(x - columnWidths[i], y, columnWidths[i], headerHeight);
                    e.Graphics.FillRectangle(Brushes.LightSteelBlue, rect);
                    e.Graphics.DrawRectangle(Pens.Gray, rect.X, rect.Y, rect.Width, rect.Height);
                    e.Graphics.DrawString(dgvReport.Columns[i].HeaderText, headerFont, Brushes.Black, rect, centerAlign);
                    x -= columnWidths[i];
                }
                y += headerHeight + 4;
            }

            // چاپ سطرهای داده‌ها تا پر شدن صفحه
            while (currentPrintState.CurrentRowIndex < currentPrintState.Rows.Count)
            {
                if (y + rowHeight > maxY)
                {
                    e.HasMorePages = true;
                    currentPrintState.IsFirstPage = false;
                    currentPrintState.PageNumber++;
                    return;
                }

                DataGridViewRow row = currentPrintState.Rows[currentPrintState.CurrentRowIndex];
                float x = e.MarginBounds.Right;

                for (int i = 0; i < dgvReport.Columns.Count; i++)
                {
                    RectangleF rect = new RectangleF(x - columnWidths[i], y, columnWidths[i], rowHeight);
                    if (currentPrintState.CurrentRowIndex % 2 == 0)
                        e.Graphics.FillRectangle(Brushes.WhiteSmoke, rect);

                    e.Graphics.DrawRectangle(Pens.LightGray, rect.X, rect.Y, rect.Width, rect.Height);
                    string cellValue = row.Cells[i].Value?.ToString() ?? "";
                    e.Graphics.DrawString(cellValue, contentFont, Brushes.Black, rect, singleLineFormat);
                    x -= columnWidths[i];
                }

                y += rowHeight + 2;
                currentPrintState.CurrentRowIndex++;
            }

            // چاپ سطر مجموع (اگر هست)
            if (currentPrintState.CurrentRowIndex >= currentPrintState.Rows.Count && currentPrintState.TotalRow != null)
            {
                if (y + headerHeight <= maxY)
                {
                    float x = e.MarginBounds.Right;
                    for (int i = 0; i < dgvReport.Columns.Count; i++)
                    {
                        RectangleF rect = new RectangleF(x - columnWidths[i], y, columnWidths[i], headerHeight);
                        e.Graphics.FillRectangle(Brushes.LightGoldenrodYellow, rect);
                        e.Graphics.DrawRectangle(Pens.Black, rect.X, rect.Y, rect.Width, rect.Height);
                        string cellValue = currentPrintState.TotalRow.Cells[i].Value?.ToString() ?? "";
                        e.Graphics.DrawString(cellValue, headerFont, Brushes.Black, rect, singleLineFormat);
                        x -= columnWidths[i];
                    }
                    y += headerHeight + 2;
                }
            }

            // پاورقی
            string footer = $"صفحه {currentPrintState.PageNumber} | تاریخ چاپ: {DateTime.Now:yyyy/MM/dd HH:mm}";
            e.Graphics.DrawString(footer, footerFont, Brushes.Gray, rightMargin, e.MarginBounds.Bottom - footerFont.GetHeight(e.Graphics), rightAlign);

            // بررسی ادامه صفحات
            e.HasMorePages = currentPrintState.CurrentRowIndex < currentPrintState.Rows.Count;

            if (!e.HasMorePages)
                currentPrintState = null;
        }

        private float CalculateCellHeight(PrintPageEventArgs e, string text, Font font, float maxWidth)
        {
          
            return font.GetHeight(e.Graphics) + 6;
        }

        private void dgvReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string input = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                comboBox1.SelectedIndex = -1; // اگر خالی بود، هیچ آیتمی انتخاب نشود
                return;
            }

            bool found = false;

            // جستجو در آیتم‌های ComboBox
            foreach (var item in comboBox1.Items)
            {
                // فرض می‌کنیم DisplayMember = "Id" یا "FullName" است
                string displayValue = comboBox1.GetItemText(item);

                if (displayValue.Equals(input, StringComparison.OrdinalIgnoreCase))
                {
                    comboBox1.SelectedItem = item;
                    found = true;
                    break;
                }
            }

            // اگر پیدا نشد، انتخاب را حذف کن
            if (!found)
                comboBox1.SelectedIndex = -1;
        }

        private void dateTimePickerX1_Load(object sender, EventArgs e)
        {

        }

      
        private void InitializeCompanyEvents()
        {
            txtCompanyName.TextChanged += TxtCompanyName_TextChanged;
          
        }

        private void TxtCompanyName_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void DateFilters_ValueChanged(object sender, EventArgs e)
        {
           
        }

      

        //1111111111
        private void dateTimePickerX1_SelectedDateChanged(DateTime selectedDateTime, BehComponents.PersianDateTime selectedPersianDateTime)
        {
           
        }

        private void dateTimePickerX2_SelectedDateChanged(DateTime selectedDateTime, BehComponents.PersianDateTime selectedPersianDateTime)
        {
           
        }

        private void FrmMain_Load_2(object sender, EventArgs e)
        {

        }

        //11111111

        // 👇 این بخش را در انتهای کلاس FrmMain بگذار، قبل از آخرین آکولاد بسته "}"
        // 👇 این کد را در انتهای کلاس FrmMain بگذار (قبل از آخرین آکولاد بسته)
        //private void UpdatePresentCount()
        //{
        //    try
        //    {
        //        string companyName = txtCompanyName.Text.Trim();
        //        if (string.IsNullOrEmpty(companyName))
        //        {
        //            txtPresentCount.Text = "0";
        //            return;
        //        }

        //        // 👇 تاریخ‌ها از متن تقویم‌ها خوانده می‌شوند
        //        DateTime fromDate = ConvertShamsiToMiladi(dateTimePickerX3.Text);
        //        DateTime toDate = ConvertShamsiToMiladi(dateTimePickerX4.Text);

        //        // گرفتن همه کارمندان شرکت مورد نظر
        //        var allEmployees = _employeeManager.GetAllEmployees()
        //            .Where(e => e.FatherName== companyName)
        //            .ToList();

        //        int presentCount = 0;

        //        foreach (var emp in allEmployees)
        //        {
        //            var report = _attendanceManager.GetAttendanceReport(emp.Id, fromDate, toDate);

        //            // ✅ اگر می‌خواهی هر بار ورود حساب شود:
        //            presentCount += report.Count(r => r.EntryTime.HasValue);

        //            // ❌ اگر فقط می‌خواهی بدانی آیا آمده یا نه:
        //            // if (report.Any(r => r.EntryTime.HasValue))
        //            //     presentCount++;
        //        }

        //        txtPresentCount.Text = presentCount.ToString();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("خطا در محاسبه تعداد حضور: " + ex.Message);
        //    }
        //}


        //private void UpdatePresentCount()
        //{
        //    try
        //    {
        //        string companyName = txtCompanyName.Text.Trim();

        //        // 🗓 تبدیل تاریخ‌های انتخاب‌شده
        //        DateTime fromDate = ConvertShamsiToMiladi(dateTimePickerX3.Text);
        //        DateTime toDate = ConvertShamsiToMiladi(dateTimePickerX4.Text);

        //        // 👨‍💼 همه‌ی کارمندان را می‌گیریم
        //        var allEmployees = _employeeManager.GetAllEmployees().ToList();

        //        int presentCountForCompany = 0;
        //        int totalPresentCount = 0;

        //        foreach (var emp in allEmployees)
        //        {
        //            var report = _attendanceManager.GetAttendanceReport(emp.Id, fromDate, toDate);

        //            // 🔹 شمارش همه ورودها
        //            totalPresentCount += report.Count(r => r.EntryTime.HasValue);

        //            // 🔹 شمارش مخصوص شرکت واردشده
        //            if (!string.IsNullOrEmpty(companyName) && emp.FatherName == companyName)
        //            {
        //                presentCountForCompany += report.Count(r => r.EntryTime.HasValue);
        //            }
        //        }

        //        // 📊 نمایش نتایج در تکس‌باکس‌ها
        //        txtPresentCount.Text = presentCountForCompany.ToString();
        //        txtTotalPresentCount.Text = totalPresentCount.ToString();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("خطا در محاسبه تعداد حضور: " + ex.Message);
        //    }
        //}

        //    private void txtCompanyName_TextChanged_1(object sender, EventArgs e)
        //{
        //    UpdatePresentCount();
        //}

        private void dateTimePickerX1_Leave(object sender, EventArgs e)
        {
          //  UpdatePresentCount();
        }

        private void dateTimePickerX2_Leave(object sender, EventArgs e)
        {
           // UpdatePresentCount();
        }

        //private void dateTimePickerX3_Leave(object sender, EventArgs e)
        //{
        //    UpdatePresentCount();
        //}

        //private void dateTimePickerX4_Leave(object sender, EventArgs e)
        //{
        //    UpdatePresentCount();
        //}

        private void dateTimePickerX3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show(
      "این قابلیت در نسخه Demo غیرفعال است.",
      "Demo Version",
      MessageBoxButtons.OK,
      MessageBoxIcon.Information);
        }

        private void btnEntry_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(
      "این قابلیت در نسخه Demo غیرفعال است.",
      "Demo Version",
      MessageBoxButtons.OK,
      MessageBoxIcon.Information);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(
      "این قابلیت در نسخه Demo غیرفعال است.",
      "Demo Version",
      MessageBoxButtons.OK,
      MessageBoxIcon.Information);
        }

        private void btnHourlyLeave_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(
      "این قابلیت در نسخه Demo غیرفعال است.",
      "Demo Version",
      MessageBoxButtons.OK,
      MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
      "این قابلیت در نسخه Demo غیرفعال است.",
      "Demo Version",
      MessageBoxButtons.OK,
      MessageBoxIcon.Information);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
      "این قابلیت در نسخه Demo غیرفعال است.",
      "Demo Version",
      MessageBoxButtons.OK,
      MessageBoxIcon.Information);
        }

        private void btnReport_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(
      "این قابلیت در نسخه Demo غیرفعال است.",
      "Demo Version",
      MessageBoxButtons.OK,
      MessageBoxIcon.Information);
        }


        //11111111111

    }






}


//15