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

        [Display(Name = "Conducting")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Bishopric { get; set; }

        [Display(Name = "Opening Hymn")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string OpeningHymn { get; set; }

        [Display(Name = "Opening Prayer")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string OpeningPray { get; set; }

        [Display(Name = "Sacrament Hymn")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string SacramentHymn { get; set; }

        [Display(Name = "First Speaker")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string FirstSpeaker { get; set; }

        [Display(Name = "Second Speaker")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string SecondSpeaker { get; set; }

        [Display(Name = "Intermediate Hymn")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string IntermediateHymn { get; set; }

        [Display(Name = "Third Speaker")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string ThirdSpeaker { get; set; }

        [Display(Name = "Fourth Speaker")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string FourthSpeaker { get; set; }

        [Display(Name = "Closing Hymn")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string ClosingHymn { get; set; }

        [Display(Name = "Closing Prayer")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string ClosingPrayer { get; set; }
    }
}
