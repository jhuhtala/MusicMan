﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicMan.Forms
{
  public partial class NotesForm : Form
  {


    public NotesForm(int personKey)
    {
      InitializeComponent();
      PersonKey = personKey;
      LoadNotesGrid();
    }

    public int PersonKey { get; }

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

    private void cmdNew_Click(object sender, EventArgs e)
    {
      var noteDetail = new NoteDetailForm(PersonKey, 0);
      noteDetail.ShowDialog();
      LoadNotesGrid();
    }

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

    private void grdNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      cmdEdit_Click(null,null);
    }
  }
}