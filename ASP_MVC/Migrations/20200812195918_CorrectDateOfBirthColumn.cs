using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_MVC.Migrations
{
    public partial class CorrectDateOfBirthColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBorth",
                table: "ContactListEntry");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "ContactListEntry",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "ContactListEntry");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBorth",
                table: "ContactListEntry",
                type: "datetime2",
                nullable: true);
        }
    }
}
