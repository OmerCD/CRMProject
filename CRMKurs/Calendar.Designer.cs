
namespace CRMKurs
{
    partial class Calendar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange1 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange2 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange3 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange4 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange5 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            this.MainCalendar = new System.Windows.Forms.Calendar.Calendar();
            this.MonthView = new System.Windows.Forms.Calendar.MonthView();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainCalendar
            // 
            this.MainCalendar.Font = new System.Drawing.Font("Segoe UI", 9F);
            calendarHighlightRange1.DayOfWeek = System.DayOfWeek.Monday;
            calendarHighlightRange1.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange1.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange2.DayOfWeek = System.DayOfWeek.Tuesday;
            calendarHighlightRange2.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange2.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange3.DayOfWeek = System.DayOfWeek.Wednesday;
            calendarHighlightRange3.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange3.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange4.DayOfWeek = System.DayOfWeek.Thursday;
            calendarHighlightRange4.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange4.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange5.DayOfWeek = System.DayOfWeek.Friday;
            calendarHighlightRange5.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange5.StartTime = System.TimeSpan.Parse("08:00:00");
            this.MainCalendar.HighlightRanges = new System.Windows.Forms.Calendar.CalendarHighlightRange[] {
        calendarHighlightRange1,
        calendarHighlightRange2,
        calendarHighlightRange3,
        calendarHighlightRange4,
        calendarHighlightRange5};
            this.MainCalendar.Location = new System.Drawing.Point(211, 5);
            this.MainCalendar.Name = "MainCalendar";
            this.MainCalendar.Size = new System.Drawing.Size(627, 432);
            this.MainCalendar.TabIndex = 0;
            this.MainCalendar.Text = "calendar1";
            // 
            // MonthView
            // 
            this.MonthView.ArrowsColor = System.Drawing.SystemColors.Window;
            this.MonthView.ArrowsSelectedColor = System.Drawing.Color.Gold;
            this.MonthView.DayBackgroundColor = System.Drawing.Color.Empty;
            this.MonthView.DayGrayedText = System.Drawing.SystemColors.GrayText;
            this.MonthView.DaySelectedBackgroundColor = System.Drawing.SystemColors.Highlight;
            this.MonthView.DaySelectedColor = System.Drawing.SystemColors.WindowText;
            this.MonthView.DaySelectedTextColor = System.Drawing.SystemColors.HighlightText;
            this.MonthView.ItemPadding = new System.Windows.Forms.Padding(2);
            this.MonthView.Location = new System.Drawing.Point(4, 5);
            this.MonthView.MaxSelectionCount = 14;
            this.MonthView.MonthTitleColor = System.Drawing.SystemColors.ActiveCaption;
            this.MonthView.MonthTitleColorInactive = System.Drawing.SystemColors.InactiveCaption;
            this.MonthView.MonthTitleTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MonthView.MonthTitleTextColorInactive = System.Drawing.SystemColors.InactiveCaptionText;
            this.MonthView.Name = "MonthView";
            this.MonthView.Size = new System.Drawing.Size(201, 432);
            this.MonthView.TabIndex = 1;
            this.MonthView.Text = "monthView1";
            this.MonthView.TodayBorderColor = System.Drawing.Color.Maroon;
            this.MonthView.SelectionChanged += new System.EventHandler(this.MonthView_SelectionChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(763, 443);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Calendar
            // 
            this.ClientSize = new System.Drawing.Size(847, 472);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.MonthView);
            this.Controls.Add(this.MainCalendar);
            this.Name = "Calendar";
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.Calendar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Calendar.Calendar MainCalendar;
        private System.Windows.Forms.Calendar.MonthView MonthView;
        private System.Windows.Forms.Button btnSave;
    }
}