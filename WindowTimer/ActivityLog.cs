using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowTimer
{
    class ActivityLogEntry
    {
        public String Name { get; private set; }
        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }

        public ActivityLogEntry( String name, DateTime start, DateTime end )
        {
            Name = name;
            Start = start;
            End = end;
        }

        public override string ToString()
        {
            return ( End - Start ).ToString() + " " + Name;
        }
    }

    class ActivityLog : IEnumerable<ActivityLogEntry>
    {
        private readonly List<ActivityLogEntry> _log = new List<ActivityLogEntry>();

        public void AddEntry( String name, DateTime start, DateTime end )
        {
            _log.Add( new ActivityLogEntry( name, start, end ) );

            _log.Sort( ( e1, e2 ) => e1.End.CompareTo( e2.End ) );
        }

        public IEnumerator<ActivityLogEntry> GetEnumerator()
        {
            return _log.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
