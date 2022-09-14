using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeAlongGr9.Migrations
{
    public partial class AddedrolesanddefaultAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cd14532c-e677-43fa-a4b1-5013fa54cc10", "53a7b943-6096-4645-a911-53d8f58a8c0a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e4ed29a2-02e9-47ad-b67c-52e4c3acc22d", "db6c281e-acab-4e33-819c-e28000c7274b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3fbfedce-910a-427d-b1a8-007c70b2ac32", 0, 9001, "6aa105e8-75e7-4484-a761-fdb1c1e0607c", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAECIX/EMSsn/HNZv4vKOvEC1VOwBrSOjns6JqDYOw0SxiuCMINQpk6o5DgoUq18mtpA==", null, false, "90b33d1b-5e82-4348-9bd1-a46f7cce9926", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e4ed29a2-02e9-47ad-b67c-52e4c3acc22d", "3fbfedce-910a-427d-b1a8-007c70b2ac32" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd14532c-e677-43fa-a4b1-5013fa54cc10");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e4ed29a2-02e9-47ad-b67c-52e4c3acc22d", "3fbfedce-910a-427d-b1a8-007c70b2ac32" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4ed29a2-02e9-47ad-b67c-52e4c3acc22d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fbfedce-910a-427d-b1a8-007c70b2ac32");
        }
    }
}
