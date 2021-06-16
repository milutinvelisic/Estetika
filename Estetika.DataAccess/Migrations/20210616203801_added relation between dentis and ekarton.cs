using Microsoft.EntityFrameworkCore.Migrations;

namespace Estetika.DataAccess.Migrations
{
    public partial class addedrelationbetweendentisandekarton : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DentistId",
                table: "EKartons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EKartons_DentistId",
                table: "EKartons",
                column: "DentistId");

            migrationBuilder.AddForeignKey(
                name: "FK_EKartons_Dentists_DentistId",
                table: "EKartons",
                column: "DentistId",
                principalTable: "Dentists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EKartons_Dentists_DentistId",
                table: "EKartons");

            migrationBuilder.DropIndex(
                name: "IX_EKartons_DentistId",
                table: "EKartons");

            migrationBuilder.DropColumn(
                name: "DentistId",
                table: "EKartons");
        }
    }
}
