using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    public partial class laptop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                column: "ConcurrencyStamp",
                value: "0689cdcd-e953-42f8-8b1c-1f2b2534aa6d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e25a252-bc75-4954-86ae-63cf8b916ecf", "AQAAAAEAACcQAAAAEENg1H2JXIkRVbszgfBlVAX6/RCUq1AckIFM6WwAuITKc+kQzxO47mMtVOPe6eeA6w==", "5dc945db-e407-4b9c-b2c7-3df34f622a3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2384f25-126e-4af7-ab67-72fcb8a4f8e4", "AQAAAAEAACcQAAAAENva+chAoKpy4k2AcKcAvl5n8d4EnzGe8afBVPzKL90YyebMEJx+rN782+qeAQY32w==", "c9e0832a-67f9-404f-aab4-a3fc29dc55a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9c0920d-7f74-4436-9921-256132072320", "AQAAAAEAACcQAAAAEF2muborunoYbd1RmSPk7Ofs0KZIKo2WBoRAKSQz+Gyqqiq771y2oiqlRnOAZkCyUw==", "e3070bea-4e3b-4cc2-a154-65d7f5e1aa57" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
