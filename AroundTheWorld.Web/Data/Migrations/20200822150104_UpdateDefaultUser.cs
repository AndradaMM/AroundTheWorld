using Microsoft.EntityFrameworkCore.Migrations;

namespace AroundTheWorld.Web.Data.Migrations
{
    public partial class UpdateDefaultUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5142926a-df50-4ec6-a498-624e6b7834ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a443e92f-334a-4eec-ac31-063859625aee", "AQAAAAEAACcQAAAAEGBYwhKluUz15TvCpk1nwUjLLOeA52MAhQO/1aaXRnJT43V68jN8ZiixeYAUQsA/qA==", "96c28bb9-598d-42a3-8286-00485630fd49" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5142926a-df50-4ec6-a498-624e6b7834ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a3cac49-5aeb-4e4f-95aa-163bd9dc9a83", null, "a581e6b8-5f70-40f2-ac8c-2cdc242f6d14" });
        }
    }
}
