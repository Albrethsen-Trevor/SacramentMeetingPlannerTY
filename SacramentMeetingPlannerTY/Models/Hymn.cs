using System.Collections.Generic;

namespace SacramentMeetingPlannerTY.Models
{
    public partial class Hymn
    {
        public Hymn()
        {
            //MeetingOpeningHymnNavigation = new HashSet<Meeting>();
            //MeetingSacramentHymnNavigation = new HashSet<Meeting>();
            //MeetingIntermediateHymnNavigation = new HashSet<Meeting>();
            //MeetingClosingHymnNavigation = new HashSet<Meeting>();
        }
        public int HymnId { get; set; }
        public string HymnName { get; set; }
        public ICollection<Meeting> Meetings { get; set; }
        //public ICollection<Meeting> SacramentHymns { get; set; }
        //public ICollection<Meeting> IntermediateHymns { get; set; }
        //public ICollection<Meeting> ClosingHymns { get; set; }
    }

    
}
