using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    public partial class configs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                column: "ConcurrencyStamp",
                value: "05998ea5-792d-4b81-a83f-faebdad4943e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6c2d480-4fa7-412c-94a0-d2699b086ca5", "AQAAAAEAACcQAAAAENpQDBLNtAJlzqjxpoujgzjiRVbrRhaRG6DIkDvs+u9qjuzUFE6LSmxqcUL2B77FHg==", "00f3fda6-ec64-45b2-bc82-4524a819052e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f86c816-2601-4faf-8f2e-63f41ce1a341", "AQAAAAEAACcQAAAAEHWiiEBaO2hWBW5QnRCj4AGUXubWulvWAnA4O3snWqCRSr23gMgLQ959qLMYBxk1bQ==", "6ed495d6-4794-4917-8ab7-69d5d92c09f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27f2e9db-afd8-4382-add1-0a38032e07c9", "AQAAAAEAACcQAAAAELzOOsQX25HZlpfBZYwsaSidf9f+uWSwzwGXK8ldrI6w52ok7Fjqx1Mkqj6+uHDz8g==", "eb60a9a5-2c83-496d-845a-eb82eebf9ff0" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "AccelerationTo100", "BodyType", "ConsumptionPer100Km", "CylindersNumber", "Displacement", "EngineAspirationType", "EngineFuelType", "EngineStructureType", "Horsepower", "ImageURL", "Make", "Mileage", "Model", "PeakHorsepowerAtRPM", "PeakTorqueAtRPM", "PricePerDay", "RenterId", "SafetyRating", "Seats", "TopSpeed", "Torque", "TransmissionType", "YearOfProduction" },
                values: new object[,]
                {
                    { new Guid("1167ef05-3aaf-4ab8-8032-59d4d6bc2075"), 9.8000000000000007, 0, 7.5, 4, 2000, 1, 3, 0, 140, "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/VW_Passat_B7_1.4_TSI_BMT_Trendline_Islandgrau.JPG/1280px-VW_Passat_B7_1.4_TSI_BMT_Trendline_Islandgrau.JPG", "Volkswagen", 120000, "Passat B7", 4200, 2500, 99.0, null, 7.2000000000000002, 5, 211, 320, 1, 2014 },
                    { new Guid("1201c5ee-8aa7-4400-9009-7bfc91fa4815"), 8.6999999999999993, 0, 8.6999999999999993, 4, 2000, 0, 0, 0, 122, "https://i.pinimg.com/736x/bd/f1/67/bdf167075cbba99b9eeed9393ba24d65.jpg", "Mercedes", 460000, "190E", 5300, 3500, 239.0, null, 9.0999999999999996, 5, 230, 178, 1, 1991 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("1167ef05-3aaf-4ab8-8032-59d4d6bc2075"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("1201c5ee-8aa7-4400-9009-7bfc91fa4815"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                column: "ConcurrencyStamp",
                value: "3906cd2c-2f69-4f14-9e58-d7b6b8412925");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28fc8d99-af2c-434f-b87b-4e2cdd41302d", "AQAAAAEAACcQAAAAEKKOLDzaXingJQ58wM2JHQLLPnKSDsmWUiGkCWCJjYonhRR87DHqjgtmg4U7+2Em8w==", "05fa01f0-4144-4bac-9b2c-d577ab25d43a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9907f6e-6a1a-4b3d-89dd-e911a2d3bc9a", "AQAAAAEAACcQAAAAELAGefaBqBAi/4TWe8zK0AAfvoF9m3G1Chserah8SeeKs8RcRgFv04rYqGDx9baQVw==", "ee2590fa-7aed-4e4f-9b55-248d9484bd7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39709418-9c40-498d-8b76-a315a43b3985", "AQAAAAEAACcQAAAAEJzxEB2rlaelt7dMWEit7hSYxKVgYUyz11meQsBSgLzFkyuX/wJ+VA7lRLkhuV6E8A==", "ab421cc8-251e-44c7-b6cc-05c379eb7dd4" });
        }
    }
}
