namespace MusicMan
{
    partial class Main
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
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.calendar1 = new System.Windows.Forms.Calendar.Calendar();
      this.monthView1 = new System.Windows.Forms.Calendar.MonthView();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.btnSendInvoices = new System.Windows.Forms.Button();
      this.btnMarkPaid = new System.Windows.Forms.Button();
      this.btnEditInvoice = new System.Windows.Forms.Button();
      this.btnInvoice = new System.Windows.Forms.Button();
      this.dtTo = new System.Windows.Forms.DateTimePicker();
      this.dtFrom = new System.Windows.Forms.DateTimePicker();
      this.grdBilling = new System.Windows.Forms.DataGridView();
      this.lstBillParents = new System.Windows.Forms.ListBox();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.btnNewParent = new System.Windows.Forms.Button();
      this.btnEditParent = new System.Windows.Forms.Button();
      this.grdParents = new System.Windows.Forms.DataGridView();
      this.tabPage4 = new System.Windows.Forms.TabPage();
      this.btnNewStudent = new System.Windows.Forms.Button();
      this.btnEditStudent = new System.Windows.Forms.Button();
      this.grdStudents = new System.Windows.Forms.DataGridView();
      this.tabPage5 = new System.Windows.Forms.TabPage();
      this.linkLabel1 = new System.Windows.Forms.LinkLabel();
      this.label10 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.txtTwilioPhone = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.txtTwilioAuthKey = new System.Windows.Forms.TextBox();
      this.txtTwilioSID = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnChangePass = new System.Windows.Forms.Button();
      this.txtVenmo = new System.Windows.Forms.TextBox();
      this.txtPayPalEmail = new System.Windows.Forms.TextBox();
      this.txtBizName = new System.Windows.Forms.TextBox();
      this.txtEmail = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.btnPrint = new System.Windows.Forms.Button();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdBilling)).BeginInit();
      this.tabPage3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdParents)).BeginInit();
      this.tabPage4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdStudents)).BeginInit();
      this.tabPage5.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Controls.Add(this.tabPage3);
      this.tabControl1.Controls.Add(this.tabPage4);
      this.tabControl1.Controls.Add(this.tabPage5);
      this.tabControl1.Location = new System.Drawing.Point(32, 29);
      this.tabControl1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(3015, 1281);
      this.tabControl1.TabIndex = 0;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.calendar1);
      this.tabPage1.Controls.Add(this.monthView1);
      this.tabPage1.Location = new System.Drawing.Point(10, 48);
      this.tabPage1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.tabPage1.Size = new System.Drawing.Size(2995, 1223);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Schedule";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // calendar1
      // 
      this.calendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.calendar1.Font = new System.Drawing.Font("Segoe UI", 9F);
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
      this.calendar1.HighlightRanges = new System.Windows.Forms.Calendar.CalendarHighlightRange[] {
        calendarHighlightRange1,
        calendarHighlightRange2,
        calendarHighlightRange3,
        calendarHighlightRange4,
        calendarHighlightRange5};
      this.calendar1.Location = new System.Drawing.Point(715, 14);
      this.calendar1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.calendar1.Name = "calendar1";
      this.calendar1.Size = new System.Drawing.Size(2301, 1252);
      this.calendar1.TabIndex = 1;
      this.calendar1.Text = "calendar1";
      this.calendar1.LoadItems += new System.Windows.Forms.Calendar.Calendar.CalendarLoadEventHandler(this.calendar1_LoadItems);
      // 
      // monthView1
      // 
      this.monthView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.monthView1.ArrowsColor = System.Drawing.SystemColors.Window;
      this.monthView1.ArrowsSelectedColor = System.Drawing.Color.Gold;
      this.monthView1.DayBackgroundColor = System.Drawing.Color.Empty;
      this.monthView1.DayGrayedText = System.Drawing.SystemColors.GrayText;
      this.monthView1.DaySelectedBackgroundColor = System.Drawing.SystemColors.Highlight;
      this.monthView1.DaySelectedColor = System.Drawing.SystemColors.WindowText;
      this.monthView1.DaySelectedTextColor = System.Drawing.SystemColors.HighlightText;
      this.monthView1.ItemPadding = new System.Windows.Forms.Padding(2);
      this.monthView1.Location = new System.Drawing.Point(8, 7);
      this.monthView1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.monthView1.MonthTitleColor = System.Drawing.SystemColors.ActiveCaption;
      this.monthView1.MonthTitleColorInactive = System.Drawing.SystemColors.InactiveCaption;
      this.monthView1.MonthTitleTextColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.monthView1.MonthTitleTextColorInactive = System.Drawing.SystemColors.InactiveCaptionText;
      this.monthView1.Name = "monthView1";
      this.monthView1.Size = new System.Drawing.Size(691, 1199);
      this.monthView1.TabIndex = 0;
      this.monthView1.Text = "monthView1";
      this.monthView1.TodayBorderColor = System.Drawing.Color.Maroon;
      this.monthView1.SelectionChanged += new System.EventHandler(this.monthView1_SelectionChanged);
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.btnPrint);
      this.tabPage2.Controls.Add(this.btnSendInvoices);
      this.tabPage2.Controls.Add(this.btnMarkPaid);
      this.tabPage2.Controls.Add(this.btnEditInvoice);
      this.tabPage2.Controls.Add(this.btnInvoice);
      this.tabPage2.Controls.Add(this.dtTo);
      this.tabPage2.Controls.Add(this.dtFrom);
      this.tabPage2.Controls.Add(this.grdBilling);
      this.tabPage2.Controls.Add(this.lstBillParents);
      this.tabPage2.Location = new System.Drawing.Point(10, 48);
      this.tabPage2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.tabPage2.Size = new System.Drawing.Size(2995, 1223);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Billing";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // btnSendInvoices
      // 
      this.btnSendInvoices.Location = new System.Drawing.Point(1737, 376);
      this.btnSendInvoices.Name = "btnSendInvoices";
      this.btnSendInvoices.Size = new System.Drawing.Size(367, 71);
      this.btnSendInvoices.TabIndex = 6;
      this.btnSendInvoices.Text = "Send Invoices";
      this.btnSendInvoices.UseVisualStyleBackColor = true;
      this.btnSendInvoices.Click += new System.EventHandler(this.btnSendInvoices_Click);
      // 
      // btnMarkPaid
      // 
      this.btnMarkPaid.Location = new System.Drawing.Point(1737, 489);
      this.btnMarkPaid.Name = "btnMarkPaid";
      this.btnMarkPaid.Size = new System.Drawing.Size(367, 71);
      this.btnMarkPaid.TabIndex = 7;
      this.btnMarkPaid.Text = "Mark Paid";
      this.btnMarkPaid.UseVisualStyleBackColor = true;
      this.btnMarkPaid.Click += new System.EventHandler(this.btnMarkPaid_Click);
      // 
      // btnEditInvoice
      // 
      this.btnEditInvoice.Location = new System.Drawing.Point(1737, 150);
      this.btnEditInvoice.Name = "btnEditInvoice";
      this.btnEditInvoice.Size = new System.Drawing.Size(367, 71);
      this.btnEditInvoice.TabIndex = 4;
      this.btnEditInvoice.Text = "Adjust Amount";
      this.btnEditInvoice.UseVisualStyleBackColor = true;
      this.btnEditInvoice.Click += new System.EventHandler(this.btnEditInvoice_Click);
      // 
      // btnInvoice
      // 
      this.btnInvoice.Location = new System.Drawing.Point(1737, 263);
      this.btnInvoice.Name = "btnInvoice";
      this.btnInvoice.Size = new System.Drawing.Size(367, 71);
      this.btnInvoice.TabIndex = 5;
      this.btnInvoice.Text = "Create Invoices";
      this.btnInvoice.UseVisualStyleBackColor = true;
      this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
      // 
      // dtTo
      // 
      this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtTo.Location = new System.Drawing.Point(1355, 74);
      this.dtTo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.dtTo.Name = "dtTo";
      this.dtTo.Size = new System.Drawing.Size(297, 38);
      this.dtTo.TabIndex = 2;
      this.dtTo.ValueChanged += new System.EventHandler(this.dtToOrFrom_ValueChanged);
      // 
      // dtFrom
      // 
      this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtFrom.Location = new System.Drawing.Point(827, 74);
      this.dtFrom.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.dtFrom.Name = "dtFrom";
      this.dtFrom.Size = new System.Drawing.Size(279, 38);
      this.dtFrom.TabIndex = 1;
      this.dtFrom.ValueChanged += new System.EventHandler(this.dtToOrFrom_ValueChanged);
      // 
      // grdBilling
      // 
      this.grdBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grdBilling.Location = new System.Drawing.Point(571, 150);
      this.grdBilling.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.grdBilling.MultiSelect = false;
      this.grdBilling.Name = "grdBilling";
      this.grdBilling.RowHeadersVisible = false;
      this.grdBilling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.grdBilling.Size = new System.Drawing.Size(1088, 982);
      this.grdBilling.TabIndex = 3;
      this.grdBilling.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBilling_CellDoubleClick);
      // 
      // lstBillParents
      // 
      this.lstBillParents.FormattingEnabled = true;
      this.lstBillParents.ItemHeight = 31;
      this.lstBillParents.Location = new System.Drawing.Point(59, 38);
      this.lstBillParents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.lstBillParents.Name = "lstBillParents";
      this.lstBillParents.Size = new System.Drawing.Size(393, 1089);
      this.lstBillParents.TabIndex = 0;
      this.lstBillParents.SelectedIndexChanged += new System.EventHandler(this.lstBillParents_SelectedIndexChanged);
      // 
      // tabPage3
      // 
      this.tabPage3.Controls.Add(this.btnNewParent);
      this.tabPage3.Controls.Add(this.btnEditParent);
      this.tabPage3.Controls.Add(this.grdParents);
      this.tabPage3.Location = new System.Drawing.Point(10, 48);
      this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabPage3.Size = new System.Drawing.Size(2995, 1223);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "Parents";
      this.tabPage3.UseVisualStyleBackColor = true;
      // 
      // btnNewParent
      // 
      this.btnNewParent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnNewParent.Location = new System.Drawing.Point(2386, 1132);
      this.btnNewParent.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.btnNewParent.Name = "btnNewParent";
      this.btnNewParent.Size = new System.Drawing.Size(295, 73);
      this.btnNewParent.TabIndex = 2;
      this.btnNewParent.Text = "New";
      this.btnNewParent.UseVisualStyleBackColor = true;
      this.btnNewParent.Click += new System.EventHandler(this.btnNewParent_Click);
      // 
      // btnEditParent
      // 
      this.btnEditParent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnEditParent.Location = new System.Drawing.Point(2697, 1132);
      this.btnEditParent.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.btnEditParent.Name = "btnEditParent";
      this.btnEditParent.Size = new System.Drawing.Size(287, 73);
      this.btnEditParent.TabIndex = 1;
      this.btnEditParent.Text = "Edit";
      this.btnEditParent.UseVisualStyleBackColor = true;
      this.btnEditParent.Click += new System.EventHandler(this.btnEditParent_Click);
      // 
      // grdParents
      // 
      this.grdParents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grdParents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.grdParents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grdParents.Location = new System.Drawing.Point(5, 5);
      this.grdParents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.grdParents.MultiSelect = false;
      this.grdParents.Name = "grdParents";
      this.grdParents.RowHeadersVisible = false;
      this.grdParents.RowTemplate.Height = 40;
      this.grdParents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.grdParents.Size = new System.Drawing.Size(2988, 1087);
      this.grdParents.TabIndex = 0;
      this.grdParents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdParents_CellDoubleClick);
      // 
      // tabPage4
      // 
      this.tabPage4.Controls.Add(this.btnNewStudent);
      this.tabPage4.Controls.Add(this.btnEditStudent);
      this.tabPage4.Controls.Add(this.grdStudents);
      this.tabPage4.Location = new System.Drawing.Point(10, 48);
      this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabPage4.Size = new System.Drawing.Size(2995, 1223);
      this.tabPage4.TabIndex = 3;
      this.tabPage4.Text = "Students";
      this.tabPage4.UseVisualStyleBackColor = true;
      // 
      // btnNewStudent
      // 
      this.btnNewStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnNewStudent.Location = new System.Drawing.Point(2386, 1132);
      this.btnNewStudent.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.btnNewStudent.Name = "btnNewStudent";
      this.btnNewStudent.Size = new System.Drawing.Size(295, 73);
      this.btnNewStudent.TabIndex = 4;
      this.btnNewStudent.Text = "New";
      this.btnNewStudent.UseVisualStyleBackColor = true;
      this.btnNewStudent.Click += new System.EventHandler(this.btnNewStudent_Click);
      // 
      // btnEditStudent
      // 
      this.btnEditStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnEditStudent.Location = new System.Drawing.Point(2697, 1132);
      this.btnEditStudent.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.btnEditStudent.Name = "btnEditStudent";
      this.btnEditStudent.Size = new System.Drawing.Size(287, 73);
      this.btnEditStudent.TabIndex = 3;
      this.btnEditStudent.Text = "Edit";
      this.btnEditStudent.UseVisualStyleBackColor = true;
      this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
      // 
      // grdStudents
      // 
      this.grdStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grdStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.grdStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grdStudents.Location = new System.Drawing.Point(5, 5);
      this.grdStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.grdStudents.MultiSelect = false;
      this.grdStudents.Name = "grdStudents";
      this.grdStudents.RowHeadersVisible = false;
      this.grdStudents.RowTemplate.Height = 40;
      this.grdStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.grdStudents.Size = new System.Drawing.Size(2983, 1085);
      this.grdStudents.TabIndex = 1;
      this.grdStudents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStudents_CellDoubleClick);
      // 
      // tabPage5
      // 
      this.tabPage5.Controls.Add(this.linkLabel1);
      this.tabPage5.Controls.Add(this.label10);
      this.tabPage5.Controls.Add(this.label9);
      this.tabPage5.Controls.Add(this.label8);
      this.tabPage5.Controls.Add(this.txtTwilioPhone);
      this.tabPage5.Controls.Add(this.label7);
      this.tabPage5.Controls.Add(this.txtTwilioAuthKey);
      this.tabPage5.Controls.Add(this.txtTwilioSID);
      this.tabPage5.Controls.Add(this.label6);
      this.tabPage5.Controls.Add(this.label5);
      this.tabPage5.Controls.Add(this.btnSave);
      this.tabPage5.Controls.Add(this.btnChangePass);
      this.tabPage5.Controls.Add(this.txtVenmo);
      this.tabPage5.Controls.Add(this.txtPayPalEmail);
      this.tabPage5.Controls.Add(this.txtBizName);
      this.tabPage5.Controls.Add(this.txtEmail);
      this.tabPage5.Controls.Add(this.label4);
      this.tabPage5.Controls.Add(this.label3);
      this.tabPage5.Controls.Add(this.label2);
      this.tabPage5.Controls.Add(this.label1);
      this.tabPage5.Location = new System.Drawing.Point(10, 48);
      this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabPage5.Name = "tabPage5";
      this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabPage5.Size = new System.Drawing.Size(2995, 1223);
      this.tabPage5.TabIndex = 4;
      this.tabPage5.Text = "Config";
      this.tabPage5.UseVisualStyleBackColor = true;
      // 
      // linkLabel1
      // 
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.Location = new System.Drawing.Point(840, 614);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new System.Drawing.Size(150, 32);
      this.linkLabel1.TabIndex = 19;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "Twilio.com";
      this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(840, 551);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(503, 32);
      this.label10.TabIndex = 18;
      this.label10.Text = "Enter each into the related boxes here.";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(840, 480);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(774, 32);
      this.label9.TabIndex = 17;
      this.label9.Text = "Twilio will provide three values, SID, Auth Key and Phone #. ";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(840, 403);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(818, 32);
      this.label8.TabIndex = 16;
      this.label8.Text = "To setup Twilio, please go to twilio.com and create an account.  ";
      // 
      // txtTwilioPhone
      // 
      this.txtTwilioPhone.Location = new System.Drawing.Point(318, 551);
      this.txtTwilioPhone.Name = "txtTwilioPhone";
      this.txtTwilioPhone.Size = new System.Drawing.Size(417, 38);
      this.txtTwilioPhone.TabIndex = 15;
      this.txtTwilioPhone.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(94, 554);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(210, 32);
      this.label7.TabIndex = 14;
      this.label7.Text = "Twilio Phone #:";
      this.label7.Click += new System.EventHandler(this.label7_Click);
      // 
      // txtTwilioAuthKey
      // 
      this.txtTwilioAuthKey.Location = new System.Drawing.Point(318, 477);
      this.txtTwilioAuthKey.Name = "txtTwilioAuthKey";
      this.txtTwilioAuthKey.Size = new System.Drawing.Size(417, 38);
      this.txtTwilioAuthKey.TabIndex = 13;
      // 
      // txtTwilioSID
      // 
      this.txtTwilioSID.Location = new System.Drawing.Point(318, 403);
      this.txtTwilioSID.Name = "txtTwilioSID";
      this.txtTwilioSID.Size = new System.Drawing.Size(417, 38);
      this.txtTwilioSID.TabIndex = 12;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(85, 480);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(219, 32);
      this.label6.TabIndex = 11;
      this.label6.Text = "Twilio Auth Key:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(157, 403);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(150, 32);
      this.label5.TabIndex = 10;
      this.label5.Text = "Twilio SID:";
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(609, 629);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(126, 60);
      this.btnSave.TabIndex = 9;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnChangePass
      // 
      this.btnChangePass.Location = new System.Drawing.Point(274, 629);
      this.btnChangePass.Name = "btnChangePass";
      this.btnChangePass.Size = new System.Drawing.Size(309, 60);
      this.btnChangePass.TabIndex = 8;
      this.btnChangePass.Text = "Change Password";
      this.btnChangePass.UseVisualStyleBackColor = true;
      this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
      // 
      // txtVenmo
      // 
      this.txtVenmo.Location = new System.Drawing.Point(318, 327);
      this.txtVenmo.Name = "txtVenmo";
      this.txtVenmo.Size = new System.Drawing.Size(417, 38);
      this.txtVenmo.TabIndex = 7;
      // 
      // txtPayPalEmail
      // 
      this.txtPayPalEmail.Location = new System.Drawing.Point(318, 248);
      this.txtPayPalEmail.Name = "txtPayPalEmail";
      this.txtPayPalEmail.Size = new System.Drawing.Size(417, 38);
      this.txtPayPalEmail.TabIndex = 6;
      // 
      // txtBizName
      // 
      this.txtBizName.Location = new System.Drawing.Point(318, 169);
      this.txtBizName.Name = "txtBizName";
      this.txtBizName.Size = new System.Drawing.Size(417, 38);
      this.txtBizName.TabIndex = 5;
      // 
      // txtEmail
      // 
      this.txtEmail.Location = new System.Drawing.Point(318, 90);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new System.Drawing.Size(417, 38);
      this.txtEmail.TabIndex = 4;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(57, 330);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(250, 32);
      this.label4.TabIndex = 3;
      this.label4.Text = "Venmo Username:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(114, 251);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(193, 32);
      this.label3.TabIndex = 2;
      this.label3.Text = "PayPal Email:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(86, 172);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(221, 32);
      this.label2.TabIndex = 1;
      this.label2.Text = "Business Name:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(212, 93);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(95, 32);
      this.label1.TabIndex = 0;
      this.label1.Text = "Email:";
      // 
      // btnPrint
      // 
      this.btnPrint.Location = new System.Drawing.Point(1737, 604);
      this.btnPrint.Name = "btnPrint";
      this.btnPrint.Size = new System.Drawing.Size(367, 71);
      this.btnPrint.TabIndex = 8;
      this.btnPrint.Text = "Print";
      this.btnPrint.UseVisualStyleBackColor = true;
      this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(3064, 1326);
      this.Controls.Add(this.tabControl1);
      this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.Name = "Main";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "MusicMan";
      this.Load += new System.EventHandler(this.Main_Load);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.grdBilling)).EndInit();
      this.tabPage3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.grdParents)).EndInit();
      this.tabPage4.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.grdStudents)).EndInit();
      this.tabPage5.ResumeLayout(false);
      this.tabPage5.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView grdStudents;
        private System.Windows.Forms.Calendar.Calendar calendar1;
        private System.Windows.Forms.Calendar.MonthView monthView1;
        private System.Windows.Forms.Button btnNewParent;
        private System.Windows.Forms.Button btnEditParent;
        private System.Windows.Forms.DataGridView grdParents;
        private System.Windows.Forms.Button btnNewStudent;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DataGridView grdBilling;
        private System.Windows.Forms.ListBox lstBillParents;
        private System.Windows.Forms.Button btnEditInvoice;
        private System.Windows.Forms.Button btnMarkPaid;
    private System.Windows.Forms.Button btnSendInvoices;
    private System.Windows.Forms.TextBox txtVenmo;
    private System.Windows.Forms.TextBox txtPayPalEmail;
    private System.Windows.Forms.TextBox txtBizName;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnChangePass;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.TextBox txtTwilioAuthKey;
    private System.Windows.Forms.TextBox txtTwilioSID;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtTwilioPhone;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.LinkLabel linkLabel1;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Button btnPrint;
  }
}