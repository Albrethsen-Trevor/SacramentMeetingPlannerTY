using System.Collections.Generic;

namespace SacramentMeetingPlannerTY.Models
{
    public class Speaker
    {
        public int SpeakerId { get; set; }
        public string SpeakerName { get; set; }
        public string Topic { get; set; }
        public ICollection<Meeting> Meetings { get; set; }
    }
}
