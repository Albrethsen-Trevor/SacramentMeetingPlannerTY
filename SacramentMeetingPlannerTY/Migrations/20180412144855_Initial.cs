using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SacramentMeetingPlannerTY.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meeting",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bishopric = table.Column<string>(nullable: true),
                    ClosingHymn = table.Column<string>(nullable: true),
                    ClosingPrayer = table.Column<string>(nullable: true),
                    FirstSpeaker = table.Column<string>(nullable: true),
                    FourthSpeaker = table.Column<string>(nullable: true),
                    IntermediateHymn = table.Column<string>(nullable: true),
                    MeetingDate = table.Column<DateTime>(nullable: false),
                    OpeningHymn = table.Column<string>(nullable: true),
                    OpeningPray = table.Column<string>(nullable: true),
                    SacramentHymn = table.Column<string>(nullable: true),
                    SecondSpeaker = table.Column<string>(nullable: true),
                    ThirdSpeaker = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meeting");
        }
    }
}
