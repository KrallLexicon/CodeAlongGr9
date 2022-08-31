using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeAlongGr9.Migrations
{
    public partial class Seededsomepeopleandcars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "RegNumber", "Brand", "CarModel" },
                values: new object[,]
                {
                    { "ABC-123", "Volvo", "V70" },
                    { "DEF-456", "SAAB", "93" },
                    { "GHI-789", "BMW", "E93" }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "SSN", "City", "Name" },
                values: new object[,]
                {
                    { "870328", "Stockholm", "Anna Svensson" },
                    { "880216", "Stenstorp", "Jonathan Krall" },
                    { "920202", "Anderstorp", "Anders Andersson" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "RegNumber",
                keyValue: "ABC-123");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "RegNumber",
                keyValue: "DEF-456");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "RegNumber",
                keyValue: "GHI-789");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "SSN",
                keyValue: "870328");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "SSN",
                keyValue: "880216");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "SSN",
                keyValue: "920202");
        }
    }
}
