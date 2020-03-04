using System;
using System.Linq;
using System.Windows.Forms.VisualStyles;

namespace MusicMan
{
  public partial class Schedule
  {
    /// <summary>Gets the schedule from primary key.</summary>
    /// <param name="scheduleId">The schedule identifier.</param>
    /// <returns></returns>
    public static Schedule GetScheduleFromId(int scheduleId)
    {
      using (var db = new MusicManEntities())
      {
        var schedule = db.Schedules.FirstOrDefault(x => x.ScheduleID == scheduleId);
        return schedule;
      }
    }

    /// <summary>
    ///   <para>
    ///  Gets the schedule from student foreign key.
    /// </para>
    /// </summary>
    /// <param name="studentId">The student identifier.</param>
    /// <returns></returns>
    public static Schedule GetScheduleFromStudentId(int studentId)
    {
      using (var db = new MusicManEntities())
      {
        var schedule = db.Schedules.FirstOrDefault(x => x.PersonID == studentId);
        return schedule;
      }
    }

    /// <summary>Updates the schedule from student identifier.  Creates a
    /// new schedule if one isn't found for the current student</summary>
    /// <param name="studentId">The student identifier.</param>
    /// <param name="dayOfWeek">The day of week.</param>
    /// <param name="time">The time.</param>
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

        var intDayOfWeek = (int)dayOfWeek;

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