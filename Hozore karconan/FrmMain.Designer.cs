
//ک 11
//namespace Hozore_karconan
//{
//    partial class FrmMain
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        private System.Windows.Forms.ComboBox comboEmployees;
//        private System.Windows.Forms.Button btnEntry;
//        private System.Windows.Forms.Button btnExit;
//        private System.Windows.Forms.Button btnDailyLeave;
//        private System.Windows.Forms.Button btnReport;
//        private System.Windows.Forms.DataGridView dgvReport;
//        private System.Windows.Forms.Label lblEmployee;
//        private System.Windows.Forms.Label lblFrom;
//        private System.Windows.Forms.Label lblTo;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support — do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
//            this.comboEmployees = new System.Windows.Forms.ComboBox();
//            this.btnEntry = new System.Windows.Forms.Button();
//            this.btnExit = new System.Windows.Forms.Button();
//            this.btnDailyLeave = new System.Windows.Forms.Button();
//            this.btnReport = new System.Windows.Forms.Button();
//            this.dgvReport = new System.Windows.Forms.DataGridView();
//            this.lblEmployee = new System.Windows.Forms.Label();
//            this.lblFrom = new System.Windows.Forms.Label();
//            this.lblTo = new System.Windows.Forms.Label();
//            this.dateTimePickerX1 = new BehComponents.DateTimePickerX();
//            this.dateTimePickerX2 = new BehComponents.DateTimePickerX();
//            this.button1 = new System.Windows.Forms.Button();
//            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
//            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
//            this.dateTimePickerX3 = new BehComponents.DateTimePickerX();
//            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // comboEmployees
//            // 
//            this.comboEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
//            this.comboEmployees.Font = new System.Drawing.Font("IRBadr", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
//            this.comboEmployees.FormattingEnabled = true;
//            this.comboEmployees.Location = new System.Drawing.Point(120, 19);
//            this.comboEmployees.Name = "comboEmployees";
//            this.comboEmployees.Size = new System.Drawing.Size(205, 41);
//            this.comboEmployees.TabIndex = 1;
//            // 
//            // btnEntry
//            // 
//            this.btnEntry.Font = new System.Drawing.Font("IRBadr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btnEntry.Location = new System.Drawing.Point(686, 27);
//            this.btnEntry.Name = "btnEntry";
//            this.btnEntry.Size = new System.Drawing.Size(100, 33);
//            this.btnEntry.TabIndex = 2;
//            this.btnEntry.Text = "ثبت ورود";
//            this.btnEntry.UseVisualStyleBackColor = true;
//            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
//            // 
//            // btnExit
//            // 
//            this.btnExit.Font = new System.Drawing.Font("IRBadr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btnExit.Location = new System.Drawing.Point(563, 27);
//            this.btnExit.Name = "btnExit";
//            this.btnExit.Size = new System.Drawing.Size(100, 33);
//            this.btnExit.TabIndex = 3;
//            this.btnExit.Text = "ثبت خروج";
//            this.btnExit.UseVisualStyleBackColor = true;
//            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
//            // 
//            // btnDailyLeave
//            // 
//            this.btnDailyLeave.Font = new System.Drawing.Font("IRBadr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btnDailyLeave.Location = new System.Drawing.Point(353, 27);
//            this.btnDailyLeave.Name = "btnDailyLeave";
//            this.btnDailyLeave.Size = new System.Drawing.Size(167, 33);
//            this.btnDailyLeave.TabIndex = 4;
//            this.btnDailyLeave.Text = "ثبت مرخصی روزانه";
//            this.btnDailyLeave.UseVisualStyleBackColor = true;
//            this.btnDailyLeave.Click += new System.EventHandler(this.btnDailyLeave_Click);
//            // 
//            // btnReport
//            // 
//            this.btnReport.Font = new System.Drawing.Font("IRBadr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btnReport.Location = new System.Drawing.Point(610, 96);
//            this.btnReport.Name = "btnReport";
//            this.btnReport.Size = new System.Drawing.Size(158, 44);
//            this.btnReport.TabIndex = 9;
//            this.btnReport.Text = "گزارش گیری";
//            this.btnReport.UseVisualStyleBackColor = true;
//            this.btnReport.Click += new System.EventHandler(this.btnReport_Click_1);
//            // 
//            // dgvReport
//            // 
//            this.dgvReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
//            | System.Windows.Forms.AnchorStyles.Left) 
//            | System.Windows.Forms.AnchorStyles.Right)));
//            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
//            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dgvReport.Location = new System.Drawing.Point(5, 209);
//            this.dgvReport.Name = "dgvReport";
//            this.dgvReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
//            this.dgvReport.RowTemplate.Height = 24;
//            this.dgvReport.Size = new System.Drawing.Size(933, 95);
//            this.dgvReport.TabIndex = 10;
//            // 
//            // lblEmployee
//            // 
//            this.lblEmployee.AutoSize = true;
//            this.lblEmployee.Font = new System.Drawing.Font("IRBadr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblEmployee.Location = new System.Drawing.Point(11, 27);
//            this.lblEmployee.Name = "lblEmployee";
//            this.lblEmployee.Size = new System.Drawing.Size(103, 33);
//            this.lblEmployee.TabIndex = 0;
//            this.lblEmployee.Text = "انتخاب کارمند:";
//            // 
//            // lblFrom
//            // 
//            this.lblFrom.AutoSize = true;
//            this.lblFrom.Font = new System.Drawing.Font("IRBadr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblFrom.Location = new System.Drawing.Point(11, 96);
//            this.lblFrom.Name = "lblFrom";
//            this.lblFrom.Size = new System.Drawing.Size(63, 33);
//            this.lblFrom.TabIndex = 5;
//            this.lblFrom.Text = "از تاریخ:";
//            // 
//            // lblTo
//            // 
//            this.lblTo.AutoSize = true;
//            this.lblTo.Font = new System.Drawing.Font("IRBadr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblTo.Location = new System.Drawing.Point(264, 96);
//            this.lblTo.Name = "lblTo";
//            this.lblTo.Size = new System.Drawing.Size(61, 33);
//            this.lblTo.TabIndex = 7;
//            this.lblTo.Text = "تا تاریخ:";
//            // 
//            // dateTimePickerX1
//            // 
//            this.dateTimePickerX1.AnchorSize = new System.Drawing.Size(150, 21);
//            this.dateTimePickerX1.BackColor = System.Drawing.Color.White;
//            this.dateTimePickerX1.CalendarBoldedDayForeColor = System.Drawing.Color.Blue;
//            this.dateTimePickerX1.CalendarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
//            this.dateTimePickerX1.CalendarDayRectTickness = 2F;
//            this.dateTimePickerX1.CalendarDaysBackColor = System.Drawing.Color.Black;
//            this.dateTimePickerX1.CalendarDaysFont = new System.Drawing.Font("IRBadr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.dateTimePickerX1.CalendarDaysForeColor = System.Drawing.Color.Lime;
//            this.dateTimePickerX1.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
//            this.dateTimePickerX1.CalendarEnglishBoldedDates = new System.DateTime[0];
//            this.dateTimePickerX1.CalendarEnglishHolidayDates = new System.DateTime[0];
//            this.dateTimePickerX1.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
//            this.dateTimePickerX1.CalendarHolidayForeColor = System.Drawing.Color.Red;
//            this.dateTimePickerX1.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
//            this.dateTimePickerX1.CalendarLineWeekColor = System.Drawing.Color.Black;
//            this.dateTimePickerX1.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
//            this.dateTimePickerX1.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
//            this.dateTimePickerX1.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
//            this.dateTimePickerX1.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
//            this.dateTimePickerX1.CalendarShowToday = true;
//            this.dateTimePickerX1.CalendarShowTodayRect = true;
//            this.dateTimePickerX1.CalendarShowToolTips = false;
//            this.dateTimePickerX1.CalendarShowTrailing = true;
//            this.dateTimePickerX1.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
//            this.dateTimePickerX1.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
//            this.dateTimePickerX1.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
//            this.dateTimePickerX1.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
//            this.dateTimePickerX1.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
//            this.dateTimePickerX1.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
//            this.dateTimePickerX1.CalendarTitleBackColor = System.Drawing.Color.Red;
//            this.dateTimePickerX1.CalendarTitleFont = new System.Drawing.Font("Tahoma", 8.25F);
//            this.dateTimePickerX1.CalendarTitleForeColor = System.Drawing.Color.Black;
//            this.dateTimePickerX1.CalendarTodayBackColor = System.Drawing.Color.White;
//            this.dateTimePickerX1.CalendarTodayFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
//            this.dateTimePickerX1.CalendarTodayForeColor = System.Drawing.Color.Black;
//            this.dateTimePickerX1.CalendarTodayRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
//            this.dateTimePickerX1.CalendarTodayRectTickness = 2F;
//            this.dateTimePickerX1.CalendarTrailingForeColor = System.Drawing.Color.Lime;
//            this.dateTimePickerX1.CalendarType = BehComponents.CalendarTypes.Persian;
//            this.dateTimePickerX1.CalendarWeekDaysBackColor = System.Drawing.Color.White;
//            this.dateTimePickerX1.CalendarWeekDaysFont = new System.Drawing.Font("Tahoma", 8.25F);
//            this.dateTimePickerX1.CalendarWeekDaysForeColor = System.Drawing.Color.OrangeRed;
//            this.dateTimePickerX1.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
//            this.dateTimePickerX1.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
//            this.dateTimePickerX1.ClearButtonBackColor = System.Drawing.Color.White;
//            this.dateTimePickerX1.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
//            this.dateTimePickerX1.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("dateTimePickerX1.ClearButtonImage")));
//            this.dateTimePickerX1.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
//            this.dateTimePickerX1.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
//            this.dateTimePickerX1.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
//            this.dateTimePickerX1.ClearButtonText = "";
//            this.dateTimePickerX1.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
//            this.dateTimePickerX1.ClearButtonToolTip = "";
//            this.dateTimePickerX1.ClearButtonWidth = 17;
//            this.dateTimePickerX1.ClearDateTimeWhenDownDeleteKey = true;
//            this.dateTimePickerX1.CustomFormat = "";
//            this.dateTimePickerX1.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
//            this.dateTimePickerX1.DropDownClosedWhenClickOnDays = false;
//            this.dateTimePickerX1.DropDownClosedWhenSelectedDateChanged = false;
//            this.dateTimePickerX1.Format = BehComponents.DateTimePickerX.FormatDate.Custom;
//            this.dateTimePickerX1.Format4Binding = "yyyy/MM/dd";
//            this.dateTimePickerX1.Location = new System.Drawing.Point(80, 108);
//            this.dateTimePickerX1.Name = "dateTimePickerX1";
//            this.dateTimePickerX1.RightToLeftLayout = true;
//            this.dateTimePickerX1.ShowClearButton = false;
//            this.dateTimePickerX1.Size = new System.Drawing.Size(150, 21);
//            this.dateTimePickerX1.TabIndex = 11;
//            this.dateTimePickerX1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            this.dateTimePickerX1.TextWhenClearButtonClicked = "";
//            // 
//            // dateTimePickerX2
//            // 
//            this.dateTimePickerX2.AnchorSize = new System.Drawing.Size(150, 21);
//            this.dateTimePickerX2.BackColor = System.Drawing.Color.White;
//            this.dateTimePickerX2.CalendarBoldedDayForeColor = System.Drawing.Color.Blue;
//            this.dateTimePickerX2.CalendarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
//            this.dateTimePickerX2.CalendarDayRectTickness = 2F;
//            this.dateTimePickerX2.CalendarDaysBackColor = System.Drawing.Color.Black;
//            this.dateTimePickerX2.CalendarDaysFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
//            this.dateTimePickerX2.CalendarDaysForeColor = System.Drawing.Color.Lime;
//            this.dateTimePickerX2.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
//            this.dateTimePickerX2.CalendarEnglishBoldedDates = new System.DateTime[0];
//            this.dateTimePickerX2.CalendarEnglishHolidayDates = new System.DateTime[0];
//            this.dateTimePickerX2.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
//            this.dateTimePickerX2.CalendarHolidayForeColor = System.Drawing.Color.Red;
//            this.dateTimePickerX2.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
//            this.dateTimePickerX2.CalendarLineWeekColor = System.Drawing.Color.Black;
//            this.dateTimePickerX2.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
//            this.dateTimePickerX2.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
//            this.dateTimePickerX2.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
//            this.dateTimePickerX2.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
//            this.dateTimePickerX2.CalendarShowToday = true;
//            this.dateTimePickerX2.CalendarShowTodayRect = true;
//            this.dateTimePickerX2.CalendarShowToolTips = false;
//            this.dateTimePickerX2.CalendarShowTrailing = true;
//            this.dateTimePickerX2.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
//            this.dateTimePickerX2.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
//            this.dateTimePickerX2.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
//            this.dateTimePickerX2.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
//            this.dateTimePickerX2.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
//            this.dateTimePickerX2.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
//            this.dateTimePickerX2.CalendarTitleBackColor = System.Drawing.Color.Red;
//            this.dateTimePickerX2.CalendarTitleFont = new System.Drawing.Font("Tahoma", 8.25F);
//            this.dateTimePickerX2.CalendarTitleForeColor = System.Drawing.Color.Black;
//            this.dateTimePickerX2.CalendarTodayBackColor = System.Drawing.Color.White;
//            this.dateTimePickerX2.CalendarTodayFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
//            this.dateTimePickerX2.CalendarTodayForeColor = System.Drawing.Color.Black;
//            this.dateTimePickerX2.CalendarTodayRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
//            this.dateTimePickerX2.CalendarTodayRectTickness = 2F;
//            this.dateTimePickerX2.CalendarTrailingForeColor = System.Drawing.Color.Lime;
//            this.dateTimePickerX2.CalendarType = BehComponents.CalendarTypes.Persian;
//            this.dateTimePickerX2.CalendarWeekDaysBackColor = System.Drawing.Color.White;
//            this.dateTimePickerX2.CalendarWeekDaysFont = new System.Drawing.Font("Tahoma", 8.25F);
//            this.dateTimePickerX2.CalendarWeekDaysForeColor = System.Drawing.Color.OrangeRed;
//            this.dateTimePickerX2.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
//            this.dateTimePickerX2.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
//            this.dateTimePickerX2.ClearButtonBackColor = System.Drawing.Color.White;
//            this.dateTimePickerX2.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
//            this.dateTimePickerX2.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("dateTimePickerX2.ClearButtonImage")));
//            this.dateTimePickerX2.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
//            this.dateTimePickerX2.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
//            this.dateTimePickerX2.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
//            this.dateTimePickerX2.ClearButtonText = "";
//            this.dateTimePickerX2.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
//            this.dateTimePickerX2.ClearButtonToolTip = "";
//            this.dateTimePickerX2.ClearButtonWidth = 17;
//            this.dateTimePickerX2.ClearDateTimeWhenDownDeleteKey = true;
//            this.dateTimePickerX2.CustomFormat = "";
//            this.dateTimePickerX2.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
//            this.dateTimePickerX2.DropDownClosedWhenClickOnDays = false;
//            this.dateTimePickerX2.DropDownClosedWhenSelectedDateChanged = false;
//            this.dateTimePickerX2.Format = BehComponents.DateTimePickerX.FormatDate.Custom;
//            this.dateTimePickerX2.Format4Binding = "yyyy/MM/dd";
//            this.dateTimePickerX2.Location = new System.Drawing.Point(353, 108);
//            this.dateTimePickerX2.Name = "dateTimePickerX2";
//            this.dateTimePickerX2.RightToLeftLayout = true;
//            this.dateTimePickerX2.ShowClearButton = false;
//            this.dateTimePickerX2.Size = new System.Drawing.Size(150, 21);
//            this.dateTimePickerX2.TabIndex = 12;
//            this.dateTimePickerX2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            this.dateTimePickerX2.TextWhenClearButtonClicked = "";
//            // 
//            // button1
//            // 
//            this.button1.Location = new System.Drawing.Point(660, 161);
//            this.button1.Name = "button1";
//            this.button1.Size = new System.Drawing.Size(75, 23);
//            this.button1.TabIndex = 14;
//            this.button1.Text = "button1";
//            this.button1.UseVisualStyleBackColor = true;
//            this.button1.Click += new System.EventHandler(this.button1_Click_1);
//            // 
//            // dateTimePicker1
//            // 
//            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dateTimePicker1.Location = new System.Drawing.Point(80, 164);
//            this.dateTimePicker1.Name = "dateTimePicker1";
//            this.dateTimePicker1.ShowUpDown = true;
//            this.dateTimePicker1.Size = new System.Drawing.Size(118, 20);
//            this.dateTimePicker1.TabIndex = 15;
//            // 
//            // dateTimePicker2
//            // 
//            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dateTimePicker2.Location = new System.Drawing.Point(294, 164);
//            this.dateTimePicker2.Name = "dateTimePicker2";
//            this.dateTimePicker2.ShowUpDown = true;
//            this.dateTimePicker2.Size = new System.Drawing.Size(109, 20);
//            this.dateTimePicker2.TabIndex = 16;
//            // 
//            // dateTimePickerX3
//            // 
//            this.dateTimePickerX3.AnchorSize = new System.Drawing.Size(150, 21);
//            this.dateTimePickerX3.BackColor = System.Drawing.Color.White;
//            this.dateTimePickerX3.CalendarBoldedDayForeColor = System.Drawing.Color.Blue;
//            this.dateTimePickerX3.CalendarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
//            this.dateTimePickerX3.CalendarDayRectTickness = 2F;
//            this.dateTimePickerX3.CalendarDaysBackColor = System.Drawing.Color.Black;
//            this.dateTimePickerX3.CalendarDaysFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
//            this.dateTimePickerX3.CalendarDaysForeColor = System.Drawing.Color.Lime;
//            this.dateTimePickerX3.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
//            this.dateTimePickerX3.CalendarEnglishBoldedDates = new System.DateTime[0];
//            this.dateTimePickerX3.CalendarEnglishHolidayDates = new System.DateTime[0];
//            this.dateTimePickerX3.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
//            this.dateTimePickerX3.CalendarHolidayForeColor = System.Drawing.Color.Red;
//            this.dateTimePickerX3.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
//            this.dateTimePickerX3.CalendarLineWeekColor = System.Drawing.Color.Black;
//            this.dateTimePickerX3.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
//            this.dateTimePickerX3.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
//            this.dateTimePickerX3.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
//            this.dateTimePickerX3.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
//            this.dateTimePickerX3.CalendarShowToday = true;
//            this.dateTimePickerX3.CalendarShowTodayRect = true;
//            this.dateTimePickerX3.CalendarShowToolTips = false;
//            this.dateTimePickerX3.CalendarShowTrailing = true;
//            this.dateTimePickerX3.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
//            this.dateTimePickerX3.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
//            this.dateTimePickerX3.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
//            this.dateTimePickerX3.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
//            this.dateTimePickerX3.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
//            this.dateTimePickerX3.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
//            this.dateTimePickerX3.CalendarTitleBackColor = System.Drawing.Color.Red;
//            this.dateTimePickerX3.CalendarTitleFont = new System.Drawing.Font("Tahoma", 8.25F);
//            this.dateTimePickerX3.CalendarTitleForeColor = System.Drawing.Color.Black;
//            this.dateTimePickerX3.CalendarTodayBackColor = System.Drawing.Color.White;
//            this.dateTimePickerX3.CalendarTodayFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
//            this.dateTimePickerX3.CalendarTodayForeColor = System.Drawing.Color.Black;
//            this.dateTimePickerX3.CalendarTodayRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
//            this.dateTimePickerX3.CalendarTodayRectTickness = 2F;
//            this.dateTimePickerX3.CalendarTrailingForeColor = System.Drawing.Color.Lime;
//            this.dateTimePickerX3.CalendarType = BehComponents.CalendarTypes.Persian;
//            this.dateTimePickerX3.CalendarWeekDaysBackColor = System.Drawing.Color.White;
//            this.dateTimePickerX3.CalendarWeekDaysFont = new System.Drawing.Font("Tahoma", 8.25F);
//            this.dateTimePickerX3.CalendarWeekDaysForeColor = System.Drawing.Color.OrangeRed;
//            this.dateTimePickerX3.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
//            this.dateTimePickerX3.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
//            this.dateTimePickerX3.ClearButtonBackColor = System.Drawing.Color.White;
//            this.dateTimePickerX3.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
//            this.dateTimePickerX3.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("dateTimePickerX3.ClearButtonImage")));
//            this.dateTimePickerX3.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
//            this.dateTimePickerX3.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
//            this.dateTimePickerX3.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
//            this.dateTimePickerX3.ClearButtonText = "";
//            this.dateTimePickerX3.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
//            this.dateTimePickerX3.ClearButtonToolTip = "";
//            this.dateTimePickerX3.ClearButtonWidth = 17;
//            this.dateTimePickerX3.ClearDateTimeWhenDownDeleteKey = true;
//            this.dateTimePickerX3.CustomFormat = "";
//            this.dateTimePickerX3.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
//            this.dateTimePickerX3.DropDownClosedWhenClickOnDays = false;
//            this.dateTimePickerX3.DropDownClosedWhenSelectedDateChanged = false;
//            this.dateTimePickerX3.Format = BehComponents.DateTimePickerX.FormatDate.Short;
//            this.dateTimePickerX3.Format4Binding = "yyyy/MM/dd";
//            this.dateTimePickerX3.Location = new System.Drawing.Point(459, 164);
//            this.dateTimePickerX3.Name = "dateTimePickerX3";
//            this.dateTimePickerX3.RightToLeftLayout = true;
//            this.dateTimePickerX3.ShowClearButton = false;
//            this.dateTimePickerX3.Size = new System.Drawing.Size(150, 21);
//            this.dateTimePickerX3.TabIndex = 17;
//            this.dateTimePickerX3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            this.dateTimePickerX3.TextWhenClearButtonClicked = "";
//            // 
//            // FrmMain
//            // 
//            this.ClientSize = new System.Drawing.Size(950, 460);
//            this.Controls.Add(this.dateTimePickerX3);
//            this.Controls.Add(this.dateTimePicker2);
//            this.Controls.Add(this.dateTimePicker1);
//            this.Controls.Add(this.button1);
//            this.Controls.Add(this.dateTimePickerX2);
//            this.Controls.Add(this.dateTimePickerX1);
//            this.Controls.Add(this.comboEmployees);
//            this.Controls.Add(this.btnEntry);
//            this.Controls.Add(this.btnExit);
//            this.Controls.Add(this.btnDailyLeave);
//            this.Controls.Add(this.lblEmployee);
//            this.Controls.Add(this.lblFrom);
//            this.Controls.Add(this.lblTo);
//            this.Controls.Add(this.btnReport);
//            this.Controls.Add(this.dgvReport);
//            this.Name = "FrmMain";
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            this.Text = "سیستم حضور و غیاب";
//            this.Load += new System.EventHandler(this.FrmMain_Load);
//            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private PersianDateTimeControl.PersianDatePicker persianDatePicker1;
//        private PersianDateTimeControl.PersianDatePicker persianDatePicker2;
//        private BehComponents.DateTimePickerX dateTimePickerX1;
//        private BehComponents.DateTimePickerX dateTimePickerX2;
//        private System.Windows.Forms.Button button1;
//        private System.Windows.Forms.DateTimePicker dateTimePicker1;
//        private System.Windows.Forms.DateTimePicker dateTimePicker2;
//        private BehComponents.DateTimePickerX dateTimePickerX3;
//    }
//}
//پ 11
//ش 11


namespace Hozore_karconan
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHourlyLeave;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.DataGridView dgvReport;
        private BehComponents.DateTimePickerX dateTimePickerX1;
        private BehComponents.DateTimePickerX dateTimePickerX2;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnEntry = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHourlyLeave = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.dateTimePickerX1 = new BehComponents.DateTimePickerX();
            this.dateTimePickerX2 = new BehComponents.DateTimePickerX();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.karconanDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtPresentCount = new System.Windows.Forms.TextBox();
            this.dateTimePickerX3 = new BehComponents.DateTimePickerX();
            this.dateTimePickerX4 = new BehComponents.DateTimePickerX();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalPresentCount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karconanDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntry
            // 
            this.btnEntry.BackColor = System.Drawing.Color.Lime;
            this.btnEntry.Font = new System.Drawing.Font("IRBadr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntry.Location = new System.Drawing.Point(1017, 106);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(225, 56);
            this.btnEntry.TabIndex = 1;
            this.btnEntry.Text = "ثبت ورود";
            this.toolTip1.SetToolTip(this.btnEntry, "کارمند مورد نظر را انتخاب و جهت ثبت ورودکلیک کنید ");
            this.btnEntry.UseVisualStyleBackColor = false;
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Lime;
            this.btnExit.Font = new System.Drawing.Font("IRBadr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(772, 106);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(228, 56);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "ثبت خروج";
            this.toolTip1.SetToolTip(this.btnExit, "کارمند مورد نظر را انتخاب و جهت ثبت خروج کلیک کنید ");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnHourlyLeave
            // 
            this.btnHourlyLeave.BackColor = System.Drawing.Color.Fuchsia;
            this.btnHourlyLeave.Font = new System.Drawing.Font("IRBadr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHourlyLeave.Location = new System.Drawing.Point(1017, 157);
            this.btnHourlyLeave.Name = "btnHourlyLeave";
            this.btnHourlyLeave.Size = new System.Drawing.Size(225, 51);
            this.btnHourlyLeave.TabIndex = 3;
            this.btnHourlyLeave.Text = "ثبت شروع مرخصی ساعتی";
            this.toolTip1.SetToolTip(this.btnHourlyLeave, "کارمند مورد نظر را انتخاب و جهت ثبت مرخصی ساعتی کلیک کنید ");
            this.btnHourlyLeave.UseVisualStyleBackColor = false;
            this.btnHourlyLeave.Click += new System.EventHandler(this.btnHourlyLeave_Click_1);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Purple;
            this.btnReport.Font = new System.Drawing.Font("IRBadr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.Yellow;
            this.btnReport.Location = new System.Drawing.Point(456, 214);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(221, 50);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "گزارش گیری";
            this.toolTip1.SetToolTip(this.btnReport, "جهت گزارشگیری بازه زمانی خود را انتخاب نمایید ");
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click_1);
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AllowUserToResizeColumns = false;
            this.dgvReport.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("IRBadr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvReport.ColumnHeadersHeight = 35;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("IRBadr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReport.DefaultCellStyle = dataGridViewCellStyle26;
            this.dgvReport.Location = new System.Drawing.Point(12, 388);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("IRBadr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvReport.RowHeadersWidth = 60;
            this.dgvReport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("IRBadr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReport.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvReport.Size = new System.Drawing.Size(1247, 261);
            this.dgvReport.TabIndex = 6;
            this.dgvReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReport_CellContentClick);
            // 
            // dateTimePickerX1
            // 
            this.dateTimePickerX1.AnchorSize = new System.Drawing.Size(135, 35);
            this.dateTimePickerX1.BackColor = System.Drawing.Color.White;
            this.dateTimePickerX1.CalendarBoldedDayForeColor = System.Drawing.Color.Red;
            this.dateTimePickerX1.CalendarBorderColor = System.Drawing.Color.MediumOrchid;
            this.dateTimePickerX1.CalendarDayRectTickness = 2F;
            this.dateTimePickerX1.CalendarDaysBackColor = System.Drawing.Color.White;
            this.dateTimePickerX1.CalendarDaysFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dateTimePickerX1.CalendarDaysForeColor = System.Drawing.Color.DeepPink;
            this.dateTimePickerX1.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.dateTimePickerX1.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.dateTimePickerX1.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.dateTimePickerX1.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.dateTimePickerX1.CalendarHolidayForeColor = System.Drawing.Color.Black;
            this.dateTimePickerX1.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.dateTimePickerX1.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.dateTimePickerX1.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX1.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX1.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX1.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX1.CalendarShowToday = true;
            this.dateTimePickerX1.CalendarShowTodayRect = true;
            this.dateTimePickerX1.CalendarShowToolTips = false;
            this.dateTimePickerX1.CalendarShowTrailing = true;
            this.dateTimePickerX1.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.dateTimePickerX1.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerX1.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dateTimePickerX1.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerX1.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerX1.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dateTimePickerX1.CalendarTitleBackColor = System.Drawing.Color.Aqua;
            this.dateTimePickerX1.CalendarTitleFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dateTimePickerX1.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateTimePickerX1.CalendarTodayBackColor = System.Drawing.Color.White;
            this.dateTimePickerX1.CalendarTodayFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerX1.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.dateTimePickerX1.CalendarTodayRectColor = System.Drawing.Color.Yellow;
            this.dateTimePickerX1.CalendarTodayRectTickness = 2F;
            this.dateTimePickerX1.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dateTimePickerX1.CalendarType = BehComponents.CalendarTypes.Persian;
            this.dateTimePickerX1.CalendarWeekDaysBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerX1.CalendarWeekDaysFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dateTimePickerX1.CalendarWeekDaysForeColor = System.Drawing.Color.Black;
            this.dateTimePickerX1.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.dateTimePickerX1.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
            this.dateTimePickerX1.ClearButtonBackColor = System.Drawing.Color.White;
            this.dateTimePickerX1.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePickerX1.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("dateTimePickerX1.ClearButtonImage")));
            this.dateTimePickerX1.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimePickerX1.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
            this.dateTimePickerX1.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
            this.dateTimePickerX1.ClearButtonText = "";
            this.dateTimePickerX1.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimePickerX1.ClearButtonToolTip = "";
            this.dateTimePickerX1.ClearButtonWidth = 17;
            this.dateTimePickerX1.ClearDateTimeWhenDownDeleteKey = true;
            this.dateTimePickerX1.CustomFormat = "";
            this.dateTimePickerX1.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.dateTimePickerX1.DropDownClosedWhenClickOnDays = false;
            this.dateTimePickerX1.DropDownClosedWhenSelectedDateChanged = false;
            this.dateTimePickerX1.Font = new System.Drawing.Font("IRBadr", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerX1.ForeColor = System.Drawing.Color.Crimson;
            this.dateTimePickerX1.Format = BehComponents.DateTimePickerX.FormatDate.Custom;
            this.dateTimePickerX1.Format4Binding = "yyyy/MM/dd";
            this.dateTimePickerX1.Location = new System.Drawing.Point(464, 127);
            this.dateTimePickerX1.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.dateTimePickerX1.Name = "dateTimePickerX1";
            this.dateTimePickerX1.RightToLeftLayout = true;
            this.dateTimePickerX1.ShowClearButton = false;
            this.dateTimePickerX1.Size = new System.Drawing.Size(135, 35);
            this.dateTimePickerX1.TabIndex = 7;
            this.dateTimePickerX1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dateTimePickerX1.TextWhenClearButtonClicked = "";
            this.dateTimePickerX1.SelectedDateChanged += new BehComponents.DateTimePickerX.OnSelectedDateChanged(this.dateTimePickerX1_SelectedDateChanged);
            this.dateTimePickerX1.Load += new System.EventHandler(this.dateTimePickerX1_Load);
            this.dateTimePickerX1.Leave += new System.EventHandler(this.dateTimePickerX1_Leave);
            // 
            // dateTimePickerX2
            // 
            this.dateTimePickerX2.AnchorSize = new System.Drawing.Size(136, 35);
            this.dateTimePickerX2.BackColor = System.Drawing.Color.White;
            this.dateTimePickerX2.CalendarBoldedDayForeColor = System.Drawing.Color.Red;
            this.dateTimePickerX2.CalendarBorderColor = System.Drawing.Color.MediumOrchid;
            this.dateTimePickerX2.CalendarDayRectTickness = 2F;
            this.dateTimePickerX2.CalendarDaysBackColor = System.Drawing.Color.White;
            this.dateTimePickerX2.CalendarDaysFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dateTimePickerX2.CalendarDaysForeColor = System.Drawing.Color.DeepPink;
            this.dateTimePickerX2.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.dateTimePickerX2.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.dateTimePickerX2.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.dateTimePickerX2.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.dateTimePickerX2.CalendarHolidayForeColor = System.Drawing.Color.Red;
            this.dateTimePickerX2.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.dateTimePickerX2.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.dateTimePickerX2.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX2.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX2.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX2.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX2.CalendarShowToday = true;
            this.dateTimePickerX2.CalendarShowTodayRect = true;
            this.dateTimePickerX2.CalendarShowToolTips = false;
            this.dateTimePickerX2.CalendarShowTrailing = true;
            this.dateTimePickerX2.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.dateTimePickerX2.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerX2.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dateTimePickerX2.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerX2.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerX2.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dateTimePickerX2.CalendarTitleBackColor = System.Drawing.Color.Aqua;
            this.dateTimePickerX2.CalendarTitleFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dateTimePickerX2.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateTimePickerX2.CalendarTodayBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerX2.CalendarTodayFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerX2.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.dateTimePickerX2.CalendarTodayRectColor = System.Drawing.Color.Yellow;
            this.dateTimePickerX2.CalendarTodayRectTickness = 2F;
            this.dateTimePickerX2.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dateTimePickerX2.CalendarType = BehComponents.CalendarTypes.Persian;
            this.dateTimePickerX2.CalendarWeekDaysBackColor = System.Drawing.Color.White;
            this.dateTimePickerX2.CalendarWeekDaysFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dateTimePickerX2.CalendarWeekDaysForeColor = System.Drawing.Color.Black;
            this.dateTimePickerX2.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.dateTimePickerX2.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
            this.dateTimePickerX2.ClearButtonBackColor = System.Drawing.Color.White;
            this.dateTimePickerX2.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePickerX2.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("dateTimePickerX2.ClearButtonImage")));
            this.dateTimePickerX2.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimePickerX2.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
            this.dateTimePickerX2.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
            this.dateTimePickerX2.ClearButtonText = "";
            this.dateTimePickerX2.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimePickerX2.ClearButtonToolTip = "";
            this.dateTimePickerX2.ClearButtonWidth = 17;
            this.dateTimePickerX2.ClearDateTimeWhenDownDeleteKey = true;
            this.dateTimePickerX2.CustomFormat = "";
            this.dateTimePickerX2.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.dateTimePickerX2.DropDownClosedWhenClickOnDays = false;
            this.dateTimePickerX2.DropDownClosedWhenSelectedDateChanged = false;
            this.dateTimePickerX2.Font = new System.Drawing.Font("IRBadr", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerX2.ForeColor = System.Drawing.Color.Maroon;
            this.dateTimePickerX2.Format = BehComponents.DateTimePickerX.FormatDate.Custom;
            this.dateTimePickerX2.Format4Binding = "yyyy/MM/dd";
            this.dateTimePickerX2.Location = new System.Drawing.Point(463, 172);
            this.dateTimePickerX2.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.dateTimePickerX2.Name = "dateTimePickerX2";
            this.dateTimePickerX2.RightToLeftLayout = true;
            this.dateTimePickerX2.ShowClearButton = false;
            this.dateTimePickerX2.Size = new System.Drawing.Size(136, 35);
            this.dateTimePickerX2.TabIndex = 8;
            this.dateTimePickerX2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dateTimePickerX2.TextWhenClearButtonClicked = "";
            this.dateTimePickerX2.SelectedDateChanged += new BehComponents.DateTimePickerX.OnSelectedDateChanged(this.dateTimePickerX2_SelectedDateChanged);
            this.dateTimePickerX2.Leave += new System.EventHandler(this.dateTimePickerX2_Leave);
            // 
            // lblEmployee
            // 
            this.lblEmployee.BackColor = System.Drawing.Color.Black;
            this.lblEmployee.Font = new System.Drawing.Font("IRBadr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.ForeColor = System.Drawing.Color.Red;
            this.lblEmployee.Location = new System.Drawing.Point(369, 12);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(107, 30);
            this.lblEmployee.TabIndex = 10;
            this.lblEmployee.Text = "انتخاب کارمند ";
            this.toolTip1.SetToolTip(this.lblEmployee, "کارمند مورد نظر خود را از لیست زیر انتخاب کنید ");
            this.lblEmployee.Visible = false;
            // 
            // lblFrom
            // 
            this.lblFrom.Font = new System.Drawing.Font("IRBadr", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.Yellow;
            this.lblFrom.Location = new System.Drawing.Point(608, 122);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(92, 40);
            this.lblFrom.TabIndex = 11;
            this.lblFrom.Text = "از تاریخ";
            // 
            // lblTo
            // 
            this.lblTo.Font = new System.Drawing.Font("IRBadr", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.Color.Yellow;
            this.lblTo.Location = new System.Drawing.Point(608, 170);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(91, 38);
            this.lblTo.TabIndex = 12;
            this.lblTo.Text = "تا تاریخ";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Black;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("IRBadr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Red;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 41;
            this.comboBox1.Location = new System.Drawing.Point(375, 48);
            this.comboBox1.MaxDropDownItems = 40;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(117, 49);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 13;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Fuchsia;
            this.button4.Font = new System.Drawing.Font("IRBadr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(772, 157);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(228, 50);
            this.button4.TabIndex = 18;
            this.button4.Text = "برگشت از مرخصی ساعتی ";
            this.toolTip1.SetToolTip(this.button4, "کارمند مورد نظر را انتخاب و جهت ثبت برگشت از مرخصی ساعتی کلیک کنید ");
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Blue;
            this.button5.Font = new System.Drawing.Font("IRBadr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Yellow;
            this.button5.Location = new System.Drawing.Point(772, 214);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(228, 50);
            this.button5.TabIndex = 19;
            this.button5.Text = "افزودن تعداد روز ماموریت +";
            this.toolTip1.SetToolTip(this.button5, "کلیک کنید ");
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Blue;
            this.textBox1.Font = new System.Drawing.Font("IRBadr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Yellow;
            this.textBox1.Location = new System.Drawing.Point(930, 276);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(162, 50);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox1, "نمایش روزهای ماموریت ");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Blue;
            this.button6.Font = new System.Drawing.Font("IRBadr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Yellow;
            this.button6.Location = new System.Drawing.Point(1014, 214);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(228, 50);
            this.button6.TabIndex = 21;
            this.button6.Text = "کاهش تعداد روز ماموریت- ";
            this.toolTip1.SetToolTip(this.button6, "کلیک کنید ");
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Lime;
            this.button7.Font = new System.Drawing.Font("IRBadr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(784, 332);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(470, 50);
            this.button7.TabIndex = 22;
            this.button7.Text = "ثبت ماموریت ";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Purple;
            this.button8.Font = new System.Drawing.Font("IRBadr", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Yellow;
            this.button8.Location = new System.Drawing.Point(456, 331);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(221, 50);
            this.button8.TabIndex = 23;
            this.button8.Text = "چاپ ";
            this.toolTip1.SetToolTip(this.button8, "چاپ اطلاعات جدول ");
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("IRBadr", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(827, 7);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(330, 35);
            this.label1.TabIndex = 26;
            this.label1.Text = "برای ثبت / گزارشگیری کد ملی را وارد کنید";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.label1, "کارمند مورد نظر خود را از لیست زیر انتخاب کنید ");
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("IRBadr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(12, 232);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(309, 32);
            this.label2.TabIndex = 29;
            this.label2.Text = "تعدادکارکنان حاضربتفکیک هر شرکت  در بازه زمانی انتخابی";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.label2, "کارمند مورد نظر خود را از لیست زیر انتخاب کنید ");
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("IRBadr", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(1, 157);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(339, 32);
            this.label3.TabIndex = 30;
            this.label3.Text = "نام شرکت را وارد کنید و بازه زمانی را از قسمت گزارشگیری انتخاب کنید ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.label3, "کارمند مورد نظر خود را از لیست زیر انتخاب کنید ");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.Font = new System.Drawing.Font("IRBadr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(55, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 50);
            this.button1.TabIndex = 31;
            this.button1.Text = "گزارش گیری";
            this.toolTip1.SetToolTip(this.button1, "جهت گزارشگیری بازه زمانی خود را انتخاب نمایید ");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("IRBadr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(12, 312);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(309, 22);
            this.label6.TabIndex = 37;
            this.label6.Text = "تعدادکل کارکنان حاضردر بازه زمانی انتخابی";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.label6, "کارمند مورد نظر خود را از لیست زیر انتخاب کنید ");
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(1, 669);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(1268, 11);
            this.labelX1.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(772, 51);
            this.textBox2.MaxLength = 10;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(470, 49);
            this.textBox2.TabIndex = 25;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Location = new System.Drawing.Point(55, 183);
            this.txtCompanyName.MaxLength = 25;
            this.txtCompanyName.Multiline = true;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(221, 46);
            this.txtCompanyName.TabIndex = 27;
            this.txtCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPresentCount
            // 
            this.txtPresentCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresentCount.Location = new System.Drawing.Point(55, 267);
            this.txtPresentCount.Multiline = true;
            this.txtPresentCount.Name = "txtPresentCount";
            this.txtPresentCount.ReadOnly = true;
            this.txtPresentCount.Size = new System.Drawing.Size(221, 42);
            this.txtPresentCount.TabIndex = 28;
            this.txtPresentCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePickerX3
            // 
            this.dateTimePickerX3.AnchorSize = new System.Drawing.Size(135, 35);
            this.dateTimePickerX3.BackColor = System.Drawing.Color.White;
            this.dateTimePickerX3.CalendarBoldedDayForeColor = System.Drawing.Color.Red;
            this.dateTimePickerX3.CalendarBorderColor = System.Drawing.Color.MediumOrchid;
            this.dateTimePickerX3.CalendarDayRectTickness = 2F;
            this.dateTimePickerX3.CalendarDaysBackColor = System.Drawing.Color.White;
            this.dateTimePickerX3.CalendarDaysFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dateTimePickerX3.CalendarDaysForeColor = System.Drawing.Color.DeepPink;
            this.dateTimePickerX3.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.dateTimePickerX3.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.dateTimePickerX3.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.dateTimePickerX3.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.dateTimePickerX3.CalendarHolidayForeColor = System.Drawing.Color.Black;
            this.dateTimePickerX3.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.dateTimePickerX3.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.dateTimePickerX3.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX3.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX3.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX3.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX3.CalendarShowToday = true;
            this.dateTimePickerX3.CalendarShowTodayRect = true;
            this.dateTimePickerX3.CalendarShowToolTips = false;
            this.dateTimePickerX3.CalendarShowTrailing = true;
            this.dateTimePickerX3.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.dateTimePickerX3.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerX3.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dateTimePickerX3.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerX3.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerX3.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dateTimePickerX3.CalendarTitleBackColor = System.Drawing.Color.Aqua;
            this.dateTimePickerX3.CalendarTitleFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dateTimePickerX3.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateTimePickerX3.CalendarTodayBackColor = System.Drawing.Color.White;
            this.dateTimePickerX3.CalendarTodayFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerX3.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.dateTimePickerX3.CalendarTodayRectColor = System.Drawing.Color.Yellow;
            this.dateTimePickerX3.CalendarTodayRectTickness = 2F;
            this.dateTimePickerX3.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dateTimePickerX3.CalendarType = BehComponents.CalendarTypes.Persian;
            this.dateTimePickerX3.CalendarWeekDaysBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerX3.CalendarWeekDaysFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dateTimePickerX3.CalendarWeekDaysForeColor = System.Drawing.Color.Black;
            this.dateTimePickerX3.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.dateTimePickerX3.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
            this.dateTimePickerX3.ClearButtonBackColor = System.Drawing.Color.White;
            this.dateTimePickerX3.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePickerX3.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("dateTimePickerX3.ClearButtonImage")));
            this.dateTimePickerX3.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimePickerX3.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
            this.dateTimePickerX3.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
            this.dateTimePickerX3.ClearButtonText = "";
            this.dateTimePickerX3.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimePickerX3.ClearButtonToolTip = "";
            this.dateTimePickerX3.ClearButtonWidth = 17;
            this.dateTimePickerX3.ClearDateTimeWhenDownDeleteKey = true;
            this.dateTimePickerX3.CustomFormat = "";
            this.dateTimePickerX3.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.dateTimePickerX3.DropDownClosedWhenClickOnDays = false;
            this.dateTimePickerX3.DropDownClosedWhenSelectedDateChanged = false;
            this.dateTimePickerX3.Font = new System.Drawing.Font("IRBadr", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerX3.ForeColor = System.Drawing.Color.Crimson;
            this.dateTimePickerX3.Format = BehComponents.DateTimePickerX.FormatDate.Custom;
            this.dateTimePickerX3.Format4Binding = "yyyy/MM/dd";
            this.dateTimePickerX3.Location = new System.Drawing.Point(62, 12);
            this.dateTimePickerX3.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.dateTimePickerX3.Name = "dateTimePickerX3";
            this.dateTimePickerX3.RightToLeftLayout = true;
            this.dateTimePickerX3.ShowClearButton = false;
            this.dateTimePickerX3.Size = new System.Drawing.Size(135, 35);
            this.dateTimePickerX3.TabIndex = 32;
            this.dateTimePickerX3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dateTimePickerX3.TextWhenClearButtonClicked = "";
            this.dateTimePickerX3.Load += new System.EventHandler(this.dateTimePickerX3_Load);
            // 
            // dateTimePickerX4
            // 
            this.dateTimePickerX4.AnchorSize = new System.Drawing.Size(136, 35);
            this.dateTimePickerX4.BackColor = System.Drawing.Color.White;
            this.dateTimePickerX4.CalendarBoldedDayForeColor = System.Drawing.Color.Red;
            this.dateTimePickerX4.CalendarBorderColor = System.Drawing.Color.MediumOrchid;
            this.dateTimePickerX4.CalendarDayRectTickness = 2F;
            this.dateTimePickerX4.CalendarDaysBackColor = System.Drawing.Color.White;
            this.dateTimePickerX4.CalendarDaysFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dateTimePickerX4.CalendarDaysForeColor = System.Drawing.Color.DeepPink;
            this.dateTimePickerX4.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.dateTimePickerX4.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.dateTimePickerX4.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.dateTimePickerX4.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.dateTimePickerX4.CalendarHolidayForeColor = System.Drawing.Color.Red;
            this.dateTimePickerX4.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.dateTimePickerX4.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.dateTimePickerX4.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX4.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX4.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX4.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX4.CalendarShowToday = true;
            this.dateTimePickerX4.CalendarShowTodayRect = true;
            this.dateTimePickerX4.CalendarShowToolTips = false;
            this.dateTimePickerX4.CalendarShowTrailing = true;
            this.dateTimePickerX4.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.dateTimePickerX4.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerX4.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dateTimePickerX4.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerX4.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerX4.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dateTimePickerX4.CalendarTitleBackColor = System.Drawing.Color.Aqua;
            this.dateTimePickerX4.CalendarTitleFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dateTimePickerX4.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateTimePickerX4.CalendarTodayBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerX4.CalendarTodayFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerX4.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.dateTimePickerX4.CalendarTodayRectColor = System.Drawing.Color.Yellow;
            this.dateTimePickerX4.CalendarTodayRectTickness = 2F;
            this.dateTimePickerX4.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dateTimePickerX4.CalendarType = BehComponents.CalendarTypes.Persian;
            this.dateTimePickerX4.CalendarWeekDaysBackColor = System.Drawing.Color.White;
            this.dateTimePickerX4.CalendarWeekDaysFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dateTimePickerX4.CalendarWeekDaysForeColor = System.Drawing.Color.Black;
            this.dateTimePickerX4.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.dateTimePickerX4.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
            this.dateTimePickerX4.ClearButtonBackColor = System.Drawing.Color.White;
            this.dateTimePickerX4.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePickerX4.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("dateTimePickerX4.ClearButtonImage")));
            this.dateTimePickerX4.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimePickerX4.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
            this.dateTimePickerX4.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
            this.dateTimePickerX4.ClearButtonText = "";
            this.dateTimePickerX4.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimePickerX4.ClearButtonToolTip = "";
            this.dateTimePickerX4.ClearButtonWidth = 17;
            this.dateTimePickerX4.ClearDateTimeWhenDownDeleteKey = true;
            this.dateTimePickerX4.CustomFormat = "";
            this.dateTimePickerX4.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.dateTimePickerX4.DropDownClosedWhenClickOnDays = false;
            this.dateTimePickerX4.DropDownClosedWhenSelectedDateChanged = false;
            this.dateTimePickerX4.Font = new System.Drawing.Font("IRBadr", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerX4.ForeColor = System.Drawing.Color.Maroon;
            this.dateTimePickerX4.Format = BehComponents.DateTimePickerX.FormatDate.Custom;
            this.dateTimePickerX4.Format4Binding = "yyyy/MM/dd";
            this.dateTimePickerX4.Location = new System.Drawing.Point(62, 51);
            this.dateTimePickerX4.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.dateTimePickerX4.Name = "dateTimePickerX4";
            this.dateTimePickerX4.RightToLeftLayout = true;
            this.dateTimePickerX4.ShowClearButton = false;
            this.dateTimePickerX4.Size = new System.Drawing.Size(136, 35);
            this.dateTimePickerX4.TabIndex = 33;
            this.dateTimePickerX4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dateTimePickerX4.TextWhenClearButtonClicked = "";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("IRBadr", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(206, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 40);
            this.label4.TabIndex = 34;
            this.label4.Text = "از تاریخ";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("IRBadr", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(206, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 38);
            this.label5.TabIndex = 35;
            this.label5.Text = "تا تاریخ";
            // 
            // txtTotalPresentCount
            // 
            this.txtTotalPresentCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPresentCount.Location = new System.Drawing.Point(55, 346);
            this.txtTotalPresentCount.Multiline = true;
            this.txtTotalPresentCount.Name = "txtTotalPresentCount";
            this.txtTotalPresentCount.Size = new System.Drawing.Size(221, 36);
            this.txtTotalPresentCount.TabIndex = 36;
            this.txtTotalPresentCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmMain
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalPresentCount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePickerX3);
            this.Controls.Add(this.dateTimePickerX4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPresentCount);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnEntry);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHourlyLeave);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.dateTimePickerX1);
            this.Controls.Add(this.dateTimePickerX2);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblTo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سیستم حضور و غیاب";
            this.Load += new System.EventHandler(this.FrmMain_Load_2);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karconanDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.BindingSource karconanDataSetBindingSource;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ToolTip toolTip1;
        private DevComponents.DotNetBar.LabelX labelX1;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtPresentCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private BehComponents.DateTimePickerX dateTimePickerX3;
        private BehComponents.DateTimePickerX dateTimePickerX4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalPresentCount;
        private System.Windows.Forms.Label label6;
    }
}

//پ 11