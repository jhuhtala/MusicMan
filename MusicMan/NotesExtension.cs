using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicMan
{
  public partial class Note
  {
    public static List<Note> GetNotesForUser(int personId)
    {
      using (var db = new MusicManEntities())
      {
        var notes = db.Notes.Where(x => x.PersonID == personId);
        return notes.ToList();
      }
    }

    public static object GetNoteGridList(int personId)
    {
      var context = new MusicManEntities();
      return context.Notes.Where(x => x.PersonID == personId).OrderBy(x => x.Date)
        .Select(x => new { x.NoteID, x.Date, x.Note1, x.IsSent }).ToList();
    }

    public static Note GetNoteFromId(int noteId)
    {
      using (var db = new MusicManEntities())
      {
        var note = db.Notes.FirstOrDefault(x => x.NoteID == noteId);
        return note;
      }
    }

    public static void CreateNote(int personKey, string noteText)
    {
      using (var db = new MusicManEntities())
      {
        var note = new Note {PersonID = personKey, Note1 = noteText,Date = DateTime.Now, IsSent = false};
        db.Notes.Add(note);
        db.SaveChanges();
      }
    }

    public static void UpdateNote(int noteKey, string noteText)
    {
      using (var db = new MusicManEntities())
      {
        var note = db.Notes.FirstOrDefault(x => x.NoteID == noteKey);
        note.Note1 = noteText;
        db.SaveChanges();
      }
    }

    public static void DeleteNote(int noteKey)
    {
      using (var db = new MusicManEntities())
      {
        var note = db.Notes.FirstOrDefault(x => x.NoteID == noteKey);
        db.Notes.Attach(note);
        db.Notes.Remove(note);
        db.SaveChanges();
      }
    }

  }
}