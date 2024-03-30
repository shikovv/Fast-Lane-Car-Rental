using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    public partial class test5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_AspNetUsers_RentalId",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "RentalId",
                table: "Cars",
                newName: "RenterId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_RentalId",
                table: "Cars",
                newName: "IX_Cars_RenterId");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_AspNetUsers_RenterId",
                table: "Cars",
                column: "RenterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_AspNetUsers_RenterId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "RenterId",
                table: "Cars",
                newName: "RentalId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_RenterId",
                table: "Cars",
                newName: "IX_Cars_RentalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_AspNetUsers_RentalId",
                table: "Cars",
                column: "RentalId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
