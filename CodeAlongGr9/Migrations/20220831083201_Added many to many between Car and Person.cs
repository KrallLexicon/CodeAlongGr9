using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeAlongGr9.Migrations
{
    public partial class AddedmanytomanybetweenCarandPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarPerson",
                columns: table => new
                {
                    CarsRegNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PeopleSSN = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarPerson", x => new { x.CarsRegNumber, x.PeopleSSN });
                    table.ForeignKey(
                        name: "FK_CarPerson_Cars_CarsRegNumber",
                        column: x => x.CarsRegNumber,
                        principalTable: "Cars",
                        principalColumn: "RegNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarPerson_People_PeopleSSN",
                        column: x => x.PeopleSSN,
                        principalTable: "People",
                        principalColumn: "SSN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarPerson_PeopleSSN",
                table: "CarPerson",
                column: "PeopleSSN");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarPerson");
        }
    }
}
