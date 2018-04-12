using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SacramentMeetingPlannerTY.Models
{
    public class Meeting
    {
        public int ID { get; set; }
        
        [Display(Name = "Meeting Date")]
        [DataType(DataType.Date)]
        public DateTime MeetingDate { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Bishopric { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string OpeningHymn { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string OpeningPray { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string SacramentHymn { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string FirstSpeaker { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string SecondSpeaker { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string IntermediateHymn { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string ThirdSpeaker { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string FourthSpeaker { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string ClosingHymn { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string ClosingPrayer { get; set; }
    }
}
