using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms.Calendar;
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
    
    public static List<DateTime> GetDayofWeekDatesBetween(DateTime startDate, DateTime endDate, DayOfWeek dayOfWeek)
    {
      List<DateTime> list = new List<DateTime>();

      // Total dates in given range. "+ 1" include endDate
      double totalDates = (endDate.Date - startDate.Date).TotalDays + 1;

      // Find first "dayOfWeek" date from startDate
      int i = dayOfWeek - startDate.DayOfWeek;
      if (i < 0) i += 7;

      // Add all "dayOfWeek" dates in given range
      for (int j = i; j < totalDates; j += 7) list.Add(startDate.AddDays(j));

      return list;
    }

    /// <summary>Updates the
    /// schedule from student identifier.  Creates a
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
        
        var timeWoSeconds = new TimeSpan(time.Hours, time.Minutes, 0);

        schedule.TimeOfDay = timeWoSeconds;

        if (newSchedule)
        {
          db.Schedules.Add(schedule);
        }

        db.SaveChanges();
      }
    }
  }
}