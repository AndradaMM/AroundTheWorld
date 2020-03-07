using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AroundTheWorld.DataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblAtwImage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAtwImage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblDiary",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    ImageId = table.Column<int>(nullable: true),
                    IsPublic = table.Column<bool>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDiary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblDiary_tblAtwImage_ImageId",
                        column: x => x.ImageId,
                        principalTable: "tblAtwImage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblChapter",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiaryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    ImageId = table.Column<int>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblChapter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblChapter_tblDiary_DiaryId",
                        column: x => x.DiaryId,
                        principalTable: "tblDiary",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblChapter_tblAtwImage_ImageId",
                        column: x => x.ImageId,
                        principalTable: "tblAtwImage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblChapter_DiaryId",
                table: "tblChapter",
                column: "DiaryId");

            migrationBuilder.CreateIndex(
                name: "IX_tblChapter_ImageId",
                table: "tblChapter",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_tblDiary_ImageId",
                table: "tblDiary",
                column: "ImageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblChapter");

            migrationBuilder.DropTable(
                name: "tblDiary");

            migrationBuilder.DropTable(
                name: "tblAtwImage");
        }
    }
}
