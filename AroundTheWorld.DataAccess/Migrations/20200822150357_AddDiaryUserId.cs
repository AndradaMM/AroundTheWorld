using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AroundTheWorld.DataAccess.Migrations
{
    public partial class AddDiaryUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "tblDiary",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "tblDiary",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: new Guid("5142926a-df50-4ec6-a498-624e6b7834ad"));

            migrationBuilder.UpdateData(
                table: "tblDiary",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: new Guid("5142926a-df50-4ec6-a498-624e6b7834ad"));

            migrationBuilder.UpdateData(
                table: "tblDiary",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: new Guid("5142926a-df50-4ec6-a498-624e6b7834ad"));

            migrationBuilder.UpdateData(
                table: "tblDiary",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserId",
                value: new Guid("5142926a-df50-4ec6-a498-624e6b7834ad"));

            migrationBuilder.UpdateData(
                table: "tblDiary",
                keyColumn: "Id",
                keyValue: 5,
                column: "UserId",
                value: new Guid("5142926a-df50-4ec6-a498-624e6b7834ad"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "tblDiary");
        }
    }
}
