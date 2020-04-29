using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MusicMan.Forms
{
  public partial class NotesForm : Form
  {


    /// <summary>Initializes a new instance of the <see cref="NotesForm" /> class.</summary>
    /// <param name="personKey">The person key.</param>
    public NotesForm(int personKey)
    {
      InitializeComponent();
      PersonKey = personKey;
      LoadNotesGrid();
    }

    public int PersonKey { get; }

    /// <summary>
    ///   <para>
    ///  Loads the notes grid.
    /// </para>
    /// </summary>
    private void LoadNotesGrid()
    {
      var noteList = Note.GetNoteGridList(PersonKey);

      grdNotes.DataSource = noteList;
      if (grdNotes.Columns["NoteID"] != null)
      {
        grdNotes.Columns["NoteID"].Visible = false;
        grdNotes.Columns["NoteID"].Tag = true;
      }

      grdNotes.Columns[1].HeaderCell.Value = "Date";
      grdNotes.Columns[2].HeaderCell.Value = "Note";
      grdNotes.Columns[3].HeaderCell.Value = "Sent";

    }

    /// <summary>Handles the Click event of the cmdEdit control.</summary>

    private void cmdEdit_Click(object sender, EventArgs e)
    {
      if (grdNotes.RowCount > 0)
      {
        var selectedRowIndex = grdNotes.SelectedCells[0].RowIndex;

        var selectedRow = grdNotes.Rows[selectedRowIndex];
        var noteId = Convert.ToInt16(selectedRow.Cells["NoteID"].Value);

        var noteDetail = new NoteDetailForm(PersonKey, noteId);
        noteDetail.ShowDialog();
        LoadNotesGrid();
      }
    }

    /// <summary>Handles the Click event of the cmdNew control.</summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    private void cmdNew_Click(object sender, EventArgs e)
    {
      var noteDetail = new NoteDetailForm(PersonKey, 0);
      noteDetail.ShowDialog();
      LoadNotesGrid();
    }

    /// <summary>Handles the Click event of the cmdDelete control.</summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    private void cmdDelete_Click(object sender, EventArgs e)
    {
      if (grdNotes.RowCount > 0)
      {
        var selectedRowIndex = grdNotes.SelectedCells[0].RowIndex;

        var selectedRow = grdNotes.Rows[selectedRowIndex];
        var noteId = Convert.ToInt16(selectedRow.Cells["NoteID"].Value);

        Note.DeleteNote(noteId);
        LoadNotesGrid();
      }
    }

    /// <summary>
    ///   <para>
    ///  Handles the CellDoubleClick event of the grdNotes control.  Causes selected item to be edited using already existing edit button click event
    /// </para>
    /// </summary>
    private void grdNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      cmdEdit_Click(null,null);
    }

    /// <summary>Handles the Click event of the btnSendNotes control.  Sends notes to the parent of the current student and marks them as sent</summary>
    private void btnSendNotes_Click(object sender, EventArgs e)
    {
      if (!MessageService.IsMessagingSetup())
      {
        MessageBox.Show(@"Twilio has not yet been setup. Please do so on the main screen config tab.");
        return;
      }
      using (var db = new MusicManEntities())
      {
        var notes = db.Notes.Where(x => x.PersonID == PersonKey);
        var noteList = notes.ToList();
        foreach (var note in noteList)
        {
          var parent = note.Person.GetParent();
          if (string.IsNullOrEmpty(parent.Phone))
          {
            MessageBox.Show(@"Parent's phone number has not been entered.  Please do so before attempting to send messages.");
            return;
          }
          if (note.IsSent != null && !note.IsSent.Value)
          {
            var user = User.GetDefaultUser();
            var message = new StringBuilder();
            message.Append("Note from ");
            message.Append(user.CompanyName);
            message.Append(" for ");
            message.Append(note.Person.FirstName);
            message.Append(": ");
            message.Append(note.Note1);

            MessageService.SendMessage(message.ToString(), "+1"+parent.Phone);
          }

          note.IsSent = true;
        }
        MessageBox.Show(@"Messages sent to parent.");

        db.SaveChanges();
      }
      LoadNotesGrid();
    }
  }
}
