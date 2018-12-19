using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SeasWebApp.Data.Migrations
{
    public partial class addGradeandAbsentToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserAbsent",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAbsent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAbsent_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserGrade",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: true),
                    GradeType = table.Column<int>(nullable: false),
                    point = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGrade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserGrade_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserAbsent_UserId",
                table: "UserAbsent",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGrade_UserId",
                table: "UserGrade",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserAbsent");

            migrationBuilder.DropTable(
                name: "UserGrade");
        }
    }
}
