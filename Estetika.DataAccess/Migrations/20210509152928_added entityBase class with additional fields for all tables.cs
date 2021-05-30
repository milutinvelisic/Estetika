using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Estetika.DataAccess.Migrations
{
    public partial class addedentityBaseclasswithadditionalfieldsforalltables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Dentists",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Dentists",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Dentists",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Dentists",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                table: "Dentists",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Dentists");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Dentists");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Dentists");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Dentists");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "Dentists");
        }
    }
}
