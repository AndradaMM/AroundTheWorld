using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AroundTheWorld.DataAccess.Migrations
{
    public partial class AddDiaryDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "tblDiary",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "tblDiary",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Date" },
                values: new object[] { new DateTime(2016, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "tblDiary",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "Date" },
                values: new object[] { new DateTime(2017, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "tblDiary",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "Date" },
                values: new object[] { new DateTime(2018, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "tblDiary",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "Date" },
                values: new object[] { new DateTime(2019, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "tblDiary",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "tblDiary");

            migrationBuilder.UpdateData(
                table: "tblDiary",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "tblDiary",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "tblDiary",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "tblDiary",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
