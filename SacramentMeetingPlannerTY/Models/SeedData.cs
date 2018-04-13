using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace SacramentMeetingPlannerTY.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SacramentMeetingPlannerTYContext(
                serviceProvider.GetRequiredService<DbContextOptions<SacramentMeetingPlannerTYContext>>()))
            {
                // Look for any meetings.
                if (context.Meeting.Any())
                {
                    return; // DB has been seeded
                }

                context.Meeting.AddRange(
                    new Meeting
                    {
                        MeetingDate = DateTime.Parse("04-08-2018"),
                        Bishopric = "Bishop Smith",
                        OpeningHymn = "The Spirit of God",
                        OpeningPray = "John Smith",
                        SacramentHymn = "With Humble Heart",
                        FirstSpeaker = "Fred Cruz",
                        SecondSpeaker = "Frank Castle",
                        IntermediateHymn = "Now Let Us Rejoice",
                        ThirdSpeaker = "Cameron Wake",
                        FourthSpeaker = "Ryan Tannehill",
                        ClosingHymn = "Redeemer of Israel",
                        ClosingPrayer = "Jane Smith"
                    },

                    new Meeting
                    {
                        MeetingDate = DateTime.Parse("04-15-2018"),
                        Bishopric = "Bishop Smith",
                        OpeningHymn = "We Thank Thee, O God, for a Prophet",
                        OpeningPray = "Jane Smith",
                        SacramentHymn = "There Is a Green Hill Far Away",
                        FirstSpeaker = "Tim Drake",
                        SecondSpeaker = "Aubrey Drake",
                        IntermediateHymn = "Sweet Hour of Prayer",
                        ThirdSpeaker = "Peter Parker",
                        FourthSpeaker = "Ben Parker",
                        ClosingHymn = "I Believe in Christ",
                        ClosingPrayer = "John Smith"
                    },

                    new Meeting
                    {
                        MeetingDate = DateTime.Parse("04-22-2018"),
                        Bishopric = "Bishop Smith",
                        OpeningHymn = "High on the Mountain Top",
                        OpeningPray = "Jason Todd",
                        SacramentHymn = "Thy Will, O Lord, Be Done",
                        FirstSpeaker = "Ann Takamaki",
                        SecondSpeaker = "Evan Tanner",
                        IntermediateHymn = "Lord, I Would Follow Thee",
                        ThirdSpeaker = "Baker Mayfield",
                        FourthSpeaker = "Marcus Mariota",
                        ClosingHymn = "Israel, Israel, God Is Calling",
                        ClosingPrayer = "Jenny Todd"
                    },

                    new Meeting
                    {
                        MeetingDate = DateTime.Parse("04-29-2018"),
                        Bishopric = "Bishop Smith",
                        OpeningHymn = "The Morning Breaks",
                        OpeningPray = "Jaime Rosales",
                        SacramentHymn = "God Loved Us, So He Sent His Son",
                        FirstSpeaker = "Trevor Albrethsen",
                        SecondSpeaker = "Yura Vasiuk",
                        IntermediateHymn = "How Great Thou Art",
                        ThirdSpeaker = "Anna Ma",
                        FourthSpeaker = "Tom Brady",
                        ClosingHymn = "Choose the Right",
                        ClosingPrayer = "Johnny Lingo"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
