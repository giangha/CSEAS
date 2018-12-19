using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SeasWebApp.Data.Migrations
{
    public partial class addClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_class",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Grade = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__class", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "userToClass",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    userId = table.Column<Guid>(nullable: true),
                    _classId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userToClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_userToClass__class__classId",
                        column: x => x._classId,
                        principalTable: "_class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_userToClass_User_userId",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_userToClass__classId",
                table: "userToClass",
                column: "_classId");

            migrationBuilder.CreateIndex(
                name: "IX_userToClass_userId",
                table: "userToClass",
                column: "userId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "userToClass");

            migrationBuilder.DropTable(
                name: "_class");
        }
    }
}
