using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SeasWebApp.Data.Migrations
{
    public partial class addAccountToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userToClass__class__classId",
                table: "userToClass");

            migrationBuilder.DropForeignKey(
                name: "FK_userToClass_User_userId",
                table: "userToClass");

            migrationBuilder.DropTable(
                name: "_class");

            migrationBuilder.DropPrimaryKey(
                name: "PK_userToClass",
                table: "userToClass");

            migrationBuilder.RenameTable(
                name: "userToClass",
                newName: "UserToClass");

            migrationBuilder.RenameColumn(
                name: "_classId",
                table: "UserToClass",
                newName: "gradeId");

            migrationBuilder.RenameIndex(
                name: "IX_userToClass_userId",
                table: "UserToClass",
                newName: "IX_UserToClass_userId");

            migrationBuilder.RenameIndex(
                name: "IX_userToClass__classId",
                table: "UserToClass",
                newName: "IX_UserToClass_gradeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserToClass",
                table: "UserToClass",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Grade",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    InGrade = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grade", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_UserToClass_Grade_gradeId",
                table: "UserToClass",
                column: "gradeId",
                principalTable: "Grade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserToClass_User_userId",
                table: "UserToClass",
                column: "userId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserToClass_Grade_gradeId",
                table: "UserToClass");

            migrationBuilder.DropForeignKey(
                name: "FK_UserToClass_User_userId",
                table: "UserToClass");

            migrationBuilder.DropTable(
                name: "Grade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserToClass",
                table: "UserToClass");

            migrationBuilder.RenameTable(
                name: "UserToClass",
                newName: "userToClass");

            migrationBuilder.RenameColumn(
                name: "gradeId",
                table: "userToClass",
                newName: "_classId");

            migrationBuilder.RenameIndex(
                name: "IX_UserToClass_userId",
                table: "userToClass",
                newName: "IX_userToClass_userId");

            migrationBuilder.RenameIndex(
                name: "IX_UserToClass_gradeId",
                table: "userToClass",
                newName: "IX_userToClass__classId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_userToClass",
                table: "userToClass",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_userToClass__class__classId",
                table: "userToClass",
                column: "_classId",
                principalTable: "_class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_userToClass_User_userId",
                table: "userToClass",
                column: "userId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
