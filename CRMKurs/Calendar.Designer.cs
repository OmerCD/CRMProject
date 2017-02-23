
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
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange16 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange17 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange18 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange19 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange20 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            this.MainCalendar = new System.Windows.Forms.Calendar.Calendar();
            this.MonthView = new System.Windows.Forms.Calendar.MonthView();
            this.SuspendLayout();
            // 
            // MainCalendar
            // 
            this.MainCalendar.Font = new System.Drawing.Font("Segoe UI", 9F);
            calendarHighlightRange16.DayOfWeek = System.DayOfWeek.Monday;
            calendarHighlightRange16.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange16.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange17.DayOfWeek = System.DayOfWeek.Tuesday;
            calendarHighlightRange17.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange17.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange18.DayOfWeek = System.DayOfWeek.Wednesday;
            calendarHighlightRange18.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange18.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange19.DayOfWeek = System.DayOfWeek.Thursday;
            calendarHighlightRange19.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange19.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange20.DayOfWeek = System.DayOfWeek.Friday;
            calendarHighlightRange20.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange20.StartTime = System.TimeSpan.Parse("08:00:00");
            this.MainCalendar.HighlightRanges = new System.Windows.Forms.Calendar.CalendarHighlightRange[] {
        calendarHighlightRange16,
        calendarHighlightRange17,
        calendarHighlightRange18,
        calendarHighlightRange19,
        calendarHighlightRange20};
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
            // Calendar
            // 
            this.ClientSize = new System.Drawing.Size(847, 449);
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
    }
}