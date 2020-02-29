namespace MusicMan
{
    partial class FrmPerson
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
            this.components = new System.ComponentModel.Container();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.chkVenmo = new System.Windows.Forms.CheckBox();
            this.chkPaypal = new System.Windows.Forms.CheckBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.numInvoiceDay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblInvoiceDay = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.numRate = new System.Windows.Forms.NumericUpDown();
            this.lblParent = new System.Windows.Forms.Label();
            this.cboDayOfWeek = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboParent = new System.Windows.Forms.ComboBox();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numInvoiceDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(896, 44);
            this.chkActive.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(131, 36);
            this.chkActive.TabIndex = 0;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // chkVenmo
            // 
            this.chkVenmo.AutoSize = true;
            this.chkVenmo.Location = new System.Drawing.Point(896, 112);
            this.chkVenmo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chkVenmo.Name = "chkVenmo";
            this.chkVenmo.Size = new System.Drawing.Size(143, 36);
            this.chkVenmo.TabIndex = 1;
            this.chkVenmo.Text = "Venmo";
            this.chkVenmo.UseVisualStyleBackColor = true;
            // 
            // chkPaypal
            // 
            this.chkPaypal.AutoSize = true;
            this.chkPaypal.Location = new System.Drawing.Point(896, 184);
            this.chkPaypal.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chkPaypal.Name = "chkPaypal";
            this.chkPaypal.Size = new System.Drawing.Size(141, 36);
            this.chkPaypal.TabIndex = 2;
            this.chkPaypal.Text = "Paypal";
            this.chkPaypal.UseVisualStyleBackColor = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(232, 44);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(353, 38);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(232, 112);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(353, 38);
            this.txtLastName.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(232, 184);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(353, 38);
            this.txtEmail.TabIndex = 5;
            // 
            // numInvoiceDay
            // 
            this.numInvoiceDay.Location = new System.Drawing.Point(896, 262);
            this.numInvoiceDay.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.numInvoiceDay.Maximum = new decimal(new int[] {
            28,
            0,
            0,
            0});
            this.numInvoiceDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numInvoiceDay.Name = "numInvoiceDay";
            this.numInvoiceDay.Size = new System.Drawing.Size(115, 38);
            this.numInvoiceDay.TabIndex = 7;
            this.numInvoiceDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Phone:";
            // 
            // lblInvoiceDay
            // 
            this.lblInvoiceDay.AutoSize = true;
            this.lblInvoiceDay.Location = new System.Drawing.Point(717, 267);
            this.lblInvoiceDay.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblInvoiceDay.Name = "lblInvoiceDay";
            this.lblInvoiceDay.Size = new System.Drawing.Size(170, 32);
            this.lblInvoiceDay.TabIndex = 12;
            this.lblInvoiceDay.Text = "Invoice Day:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(840, 498);
            this.btnSave.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 55);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(606, 498);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 55);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(33, 325);
            this.lblRate.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(183, 32);
            this.lblRate.TabIndex = 15;
            this.lblRate.Text = "Rate/Lesson:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(232, 258);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(232, 38);
            this.txtPhone.TabIndex = 16;
            this.txtPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // numRate
            // 
            this.numRate.Location = new System.Drawing.Point(232, 325);
            this.numRate.Name = "numRate";
            this.numRate.Size = new System.Drawing.Size(96, 38);
            this.numRate.TabIndex = 17;
            // 
            // lblParent
            // 
            this.lblParent.AutoSize = true;
            this.lblParent.Location = new System.Drawing.Point(108, 389);
            this.lblParent.Name = "lblParent";
            this.lblParent.Size = new System.Drawing.Size(107, 32);
            this.lblParent.TabIndex = 18;
            this.lblParent.Text = "Parent:";
            // 
            // cboDayOfWeek
            // 
            this.cboDayOfWeek.AllowDrop = true;
            this.cboDayOfWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDayOfWeek.FormattingEnabled = true;
            this.cboDayOfWeek.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.cboDayOfWeek.Location = new System.Drawing.Point(231, 452);
            this.cboDayOfWeek.Name = "cboDayOfWeek";
            this.cboDayOfWeek.Size = new System.Drawing.Size(354, 39);
            this.cboDayOfWeek.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 32);
            this.label5.TabIndex = 21;
            this.label5.Text = "Lesson Day:";
            // 
            // cboParent
            // 
            this.cboParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParent.FormattingEnabled = true;
            this.cboParent.Location = new System.Drawing.Point(232, 386);
            this.cboParent.Name = "cboParent";
            this.cboParent.Size = new System.Drawing.Size(353, 39);
            this.cboParent.TabIndex = 24;
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // FrmPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1128, 611);
            this.Controls.Add(this.cboParent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboDayOfWeek);
            this.Controls.Add(this.lblParent);
            this.Controls.Add(this.numRate);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblInvoiceDay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numInvoiceDay);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.chkPaypal);
            this.Controls.Add(this.chkVenmo);
            this.Controls.Add(this.chkActive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPerson";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.numInvoiceDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.CheckBox chkVenmo;
        private System.Windows.Forms.CheckBox chkPaypal;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.NumericUpDown numInvoiceDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblInvoiceDay;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.NumericUpDown numRate;
        private System.Windows.Forms.Label lblParent;
        private System.Windows.Forms.ComboBox cboDayOfWeek;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboParent;
        private System.Windows.Forms.ErrorProvider errProvider;
    }
}