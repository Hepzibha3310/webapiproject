using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace charitableLibrary.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "outlets",
                columns: table => new
                {
                    OutletID = table.Column<string>(type: "text", nullable: false),
                    OutletName = table.Column<string>(type: "text", nullable: true),
                    StreetName = table.Column<string>(type: "text", nullable: true),
                    Landmark = table.Column<string>(type: "text", nullable: true),
                    NumberOfAvailableFoodPacks = table.Column<int>(type: "integer", nullable: false),
                    NumberOfVolunteersRequired = table.Column<int>(type: "integer", nullable: false),
                    TypeOfFood = table.Column<string>(type: "text", nullable: true),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_outlets", x => x.OutletID);
                });

            migrationBuilder.CreateTable(
                name: "volunteers",
                columns: table => new
                {
                    VolunteerID = table.Column<string>(type: "text", nullable: false),
                    OutletID = table.Column<string>(type: "text", nullable: true),
                    VoluteerName = table.Column<string>(type: "text", nullable: true),
                    VolunteerAddress = table.Column<string>(type: "text", nullable: true),
                    VolunteerPhoneNumber = table.Column<int>(type: "integer", nullable: false),
                    VolunteerEmail = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_volunteers", x => x.VolunteerID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "outlets");

            migrationBuilder.DropTable(
                name: "volunteers");
        }
    }
}
