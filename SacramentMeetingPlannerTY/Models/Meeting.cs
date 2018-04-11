using System;
using System.Collections.Generic;

namespace SacramentMeetingPlannerTY.Models
{
    public class Meeting
    {
        public Meeting()
        {
            //Speaker = new HashSet<Speaker>();
        }

        public int MeetingId { get; set; }
        public DateTime MeetingDate { get; set; }
        public int Bishopric { get; set; }
        public string OpeningPrayer { get; set; }
        public string ClosingPrayer { get; set; }
        public int OpeningHymnId { get; set; }
        public int SacramentHymnId { get; set; }
        public int? IntermediateHymnId { get; set; }
        public int ClosingHymnId { get; set; }
        public ICollection<Speaker> Speakers { get; set; }
        public Bishopric BishopricNavigation { get; set; }

        public Hymn OpeningHymn { get; set; }
        public Hymn SacramentHymn { get; set; }
        public Hymn IntermediateHymn { get; set; }
        public Hymn ClosingHymn { get; set; }

    }
}
