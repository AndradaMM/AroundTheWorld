using Microsoft.EntityFrameworkCore.Migrations;

namespace AroundTheWorld.Web.Data.Migrations
{
    public partial class AddDefaultUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5142926a-df50-4ec6-a498-624e6b7834ad", 0, "0a3cac49-5aeb-4e4f-95aa-163bd9dc9a83", "user@test.com", true, true, null, "USER@TEST.COM", "USER@TEST.COM", null, null, false, "a581e6b8-5f70-40f2-ac8c-2cdc242f6d14", false, "user@test.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5142926a-df50-4ec6-a498-624e6b7834ad");
        }
    }
}
