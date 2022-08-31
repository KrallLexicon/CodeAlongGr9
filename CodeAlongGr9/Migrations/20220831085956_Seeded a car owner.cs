using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeAlongGr9.Migrations
{
    public partial class Seededacarowner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CarPerson",
                columns: new[] { "CarsRegNumber", "PeopleSSN" },
                values: new object[] { "ABC-123", "880216" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarPerson",
                keyColumns: new[] { "CarsRegNumber", "PeopleSSN" },
                keyValues: new object[] { "ABC-123", "880216" });
        }
    }
}
