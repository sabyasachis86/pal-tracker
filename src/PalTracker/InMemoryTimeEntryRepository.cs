using System;
using System.Collections.Generic;

namespace PalTracker
{
    public class InMemoryTimeEntryRepository : ITimeEntryRepository
    {
        long current_id = 0; 
        public Dictionary<long , TimeEntry> timeEntryobjects = new Dictionary<long, TimeEntry>();
        public bool Contains(long id)
        {
            return timeEntryobjects.ContainsKey(id);
        }

        public TimeEntry Create(TimeEntry timeEntry)
        {   
            timeEntry.Id = ++current_id ;
            timeEntryobjects.Add(current_id, timeEntry);
            return timeEntry;
            //throw new NotImplementedException();
        }

        public TimeEntry Find(long id)
        {
            if(timeEntryobjects.ContainsKey(id))
            {
                return timeEntryobjects[id];
            }
            else
            {
             return  null;
            }
        }

        public  IEnumerable<TimeEntry> List()
        {
            return timeEntryobjects.Values;
        }

        public TimeEntry Update(long id, TimeEntry timeEntry)
        {
            
                timeEntry.Id  = id ;
                timeEntryobjects[id] = timeEntry;
                return timeEntryobjects[id];      
            
          
               
        }

        public void Delete(long id)
        {
           
                timeEntryobjects.Remove(id);
            
        }
    }
}