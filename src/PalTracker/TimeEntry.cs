
using System;

namespace PalTracker
{
    public class TimeEntry
    {
       public long? Id;
       public long ProjectId;
       public long UserId;
       public DateTime Date ;
       public int Hours ;
       public TimeEntry()
       {
           
       }
        public TimeEntry(long id, long projectId, long userId, DateTime date, int hours)
        {
           this.Id = id;
           this.ProjectId = projectId;
           this.UserId = userId;
           this.Date = date;
           this.Hours = hours;
        }
        public TimeEntry(long projectId, long userId, DateTime date, int hours)
        {
           //this.id = id;
           this.ProjectId = projectId;
           this.UserId = userId;
           this.Date = date;
           this.Hours = hours;
        }

        public override bool Equals(object obj)
        {
            return obj is TimeEntry entry &&
                   Id == entry.Id &&
                   ProjectId == entry.ProjectId &&
                   UserId == entry.UserId &&
                   Date == entry.Date &&
                   Hours == entry.Hours;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, ProjectId, UserId, Date, Hours);
        }
    }
}