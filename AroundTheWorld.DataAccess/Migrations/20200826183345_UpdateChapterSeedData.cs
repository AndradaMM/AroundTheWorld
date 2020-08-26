using Microsoft.EntityFrameworkCore.Migrations;

namespace AroundTheWorld.DataAccess.Migrations
{
    public partial class UpdateChapterSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tblChapter",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");

            migrationBuilder.UpdateData(
                table: "tblChapter",
                keyColumn: "Id",
                keyValue: 2,
                column: "Content",
                value: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");

            migrationBuilder.UpdateData(
                table: "tblChapter",
                keyColumn: "Id",
                keyValue: 3,
                column: "Content",
                value: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");

            migrationBuilder.UpdateData(
                table: "tblChapter",
                keyColumn: "Id",
                keyValue: 4,
                column: "Content",
                value: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");

            migrationBuilder.UpdateData(
                table: "tblChapter",
                keyColumn: "Id",
                keyValue: 5,
                column: "Content",
                value: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");

            migrationBuilder.UpdateData(
                table: "tblChapter",
                keyColumn: "Id",
                keyValue: 6,
                column: "Content",
                value: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tblChapter",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: "Chapter 1");

            migrationBuilder.UpdateData(
                table: "tblChapter",
                keyColumn: "Id",
                keyValue: 2,
                column: "Content",
                value: "Chapter 2");

            migrationBuilder.UpdateData(
                table: "tblChapter",
                keyColumn: "Id",
                keyValue: 3,
                column: "Content",
                value: "Chapter 2");

            migrationBuilder.UpdateData(
                table: "tblChapter",
                keyColumn: "Id",
                keyValue: 4,
                column: "Content",
                value: "Chapter 2");

            migrationBuilder.UpdateData(
                table: "tblChapter",
                keyColumn: "Id",
                keyValue: 5,
                column: "Content",
                value: "Chapter 2");

            migrationBuilder.UpdateData(
                table: "tblChapter",
                keyColumn: "Id",
                keyValue: 6,
                column: "Content",
                value: "Chapter 2");
        }
    }
}
