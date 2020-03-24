namespace MusicMan.Forms
{
  partial class NotesForm
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
      this.grdNotes = new System.Windows.Forms.DataGridView();
      this.cmdNew = new System.Windows.Forms.Button();
      this.cmdEdit = new System.Windows.Forms.Button();
      this.cmdDelete = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.grdNotes)).BeginInit();
      this.SuspendLayout();
      // 
      // grdNotes
      // 
      this.grdNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.grdNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grdNotes.Location = new System.Drawing.Point(23, 21);
      this.grdNotes.MultiSelect = false;
      this.grdNotes.Name = "grdNotes";
      this.grdNotes.RowHeadersVisible = false;
      this.grdNotes.RowTemplate.Height = 40;
      this.grdNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.grdNotes.Size = new System.Drawing.Size(1382, 582);
      this.grdNotes.TabIndex = 0;
      this.grdNotes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdNotes_CellDoubleClick);
      // 
      // cmdNew
      // 
      this.cmdNew.Location = new System.Drawing.Point(1225, 632);
      this.cmdNew.Name = "cmdNew";
      this.cmdNew.Size = new System.Drawing.Size(180, 50);
      this.cmdNew.TabIndex = 1;
      this.cmdNew.Text = "New";
      this.cmdNew.UseVisualStyleBackColor = true;
      this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
      // 
      // cmdEdit
      // 
      this.cmdEdit.Location = new System.Drawing.Point(1024, 632);
      this.cmdEdit.Name = "cmdEdit";
      this.cmdEdit.Size = new System.Drawing.Size(180, 50);
      this.cmdEdit.TabIndex = 2;
      this.cmdEdit.Text = "Edit";
      this.cmdEdit.UseVisualStyleBackColor = true;
      this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
      // 
      // cmdDelete
      // 
      this.cmdDelete.Location = new System.Drawing.Point(818, 632);
      this.cmdDelete.Name = "cmdDelete";
      this.cmdDelete.Size = new System.Drawing.Size(180, 50);
      this.cmdDelete.TabIndex = 3;
      this.cmdDelete.Text = "Delete";
      this.cmdDelete.UseVisualStyleBackColor = true;
      this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
      // 
      // NotesForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1430, 713);
      this.Controls.Add(this.cmdDelete);
      this.Controls.Add(this.cmdEdit);
      this.Controls.Add(this.cmdNew);
      this.Controls.Add(this.grdNotes);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "NotesForm";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "NotesForm";
      ((System.ComponentModel.ISupportInitialize)(this.grdNotes)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView grdNotes;
    private System.Windows.Forms.Button cmdNew;
    private System.Windows.Forms.Button cmdEdit;
    private System.Windows.Forms.Button cmdDelete;
  }
}