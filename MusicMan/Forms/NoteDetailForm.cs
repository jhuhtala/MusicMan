using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicMan.Forms
{
  public partial class NoteDetailForm : Form
  {
    public NoteDetailForm(int personKey, int noteKey)
    {
      InitializeComponent();

      PersonKey = personKey;
      NoteKey = noteKey;

      if (noteKey > 0)
      {
        var note = Note.GetNoteFromId(NoteKey);
      
        txtNote.Text = note.Note1;
      }
    }

    

    public int PersonKey { get; set; }
    public int NoteKey { get; set; }

    private void btnSave_Click(object sender, EventArgs e)
    {
      if (NoteKey > 0)
      {
        Note.UpdateNote(NoteKey, txtNote.Text);
      }
      else
      {
        Note.CreateNote(PersonKey, txtNote.Text);
      }

      Close();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
