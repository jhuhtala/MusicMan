using System;
using System.Linq;
using System.Windows.Forms.VisualStyles;

namespace MusicMan
{
  public partial class Schedule
  {
    public static Schedule GetScheduleFromId(int scheduleId)
    {
      using (var db = new MusicManEntities())
      {
        var schedule = db.Schedules.FirstOrDefault(x => x.ScheduleID == scheduleId);
        return schedule;
      }
    }

    public static Schedule GetScheduleFromStudentId(int studentId)
    {
      using (var db = new MusicManEntities())
      {
        var schedule = db.Schedules.FirstOrDefault(x => x.PersonID == studentId);
        return schedule;
      }
    }

    public static void UpdateScheduleFromStudentId(int studentId, DayOfWeek dayOfWeek, TimeSpan time )
    {
      using (var db = new MusicManEntities())
      {
        var newSchedule = false;
        var schedule = db.Schedules.FirstOrDefault(x => x.PersonID == studentId);
        if (schedule == null)
        {
          newSchedule = true;
          schedule = new Schedule {PersonID = studentId};
        }

        int intDayOfWeek = (int)dayOfWeek;

        schedule.DayOfTheWeek = intDayOfWeek;
        schedule.TimeOfDay = time;

        if (newSchedule)
        {
          db.Schedules.Add(schedule);
        }

        db.SaveChanges();
      }
    }
  }
}