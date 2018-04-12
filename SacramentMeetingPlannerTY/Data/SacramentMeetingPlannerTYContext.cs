using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SacramentMeetingPlannerTY.Models
{
    public class SacramentMeetingPlannerTYContext : DbContext
    {
        public SacramentMeetingPlannerTYContext (DbContextOptions<SacramentMeetingPlannerTYContext> options)
            : base(options)
        {
        }

        public DbSet<SacramentMeetingPlannerTY.Models.Meeting> Meeting { get; set; }
    }
}
