using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlannerTY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlannerTY.Data 
{
    public class SacramentMeetingPlannerContext : DbContext
    {
        public SacramentMeetingPlannerContext(DbContextOptions<SacramentMeetingPlannerContext> options) : base(options)
        {
        }

        public DbSet<Bishopric> Bishoprics { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Hymn> Hymns { get; set; }
        public DbSet<Speaker> Speakers { get; set; }


    }
}
