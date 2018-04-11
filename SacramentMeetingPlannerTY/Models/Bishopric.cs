using System.Collections.Generic;

namespace SacramentMeetingPlannerTY.Models
{
    public class Bishopric
    {
        public Bishopric()
        {
            //Meeting = new HashSet<Meeting>();
        }
        public int BishopricId { get; set; }
        public string FullName { get; set; }
        public string Title { get; set; }

        public ICollection<Meeting> Meetings { get; set; }

    }
}
