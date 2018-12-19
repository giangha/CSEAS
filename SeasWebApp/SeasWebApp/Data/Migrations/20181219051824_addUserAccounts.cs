using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SeasWebApp.Data.Migrations
{
    public partial class addUserAccounts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AccountUserId",
                table: "User",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AccountToUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AccountId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountToUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountToUsers_AspNetUsers_AccountId",
                        column: x => x.AccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_AccountUserId",
                table: "User",
                column: "AccountUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountToUsers_AccountId",
                table: "AccountToUsers",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_AccountToUsers_AccountUserId",
                table: "User",
                column: "AccountUserId",
                principalTable: "AccountToUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_AccountToUsers_AccountUserId",
                table: "User");

            migrationBuilder.DropTable(
                name: "AccountToUsers");

            migrationBuilder.DropIndex(
                name: "IX_User_AccountUserId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "AccountUserId",
                table: "User");
        }
    }
}
