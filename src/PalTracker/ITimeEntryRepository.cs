using System;
using System.Collections.Generic;

namespace PalTracker
{
    public interface ITimeEntryRepository
    {
        TimeEntry Find(long id); 
        TimeEntry Create(TimeEntry timeEntry); 
        IEnumerable<TimeEntry> List();
        TimeEntry Update(long id, TimeEntry timeEntry);
        bool Contains(long id);

         void Delete(long id);
    }
}