using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("1201c5ee-8aa7-4400-9009-7bfc91fa4815"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                column: "ConcurrencyStamp",
                value: "8eacdf59-6c37-4fe6-9aab-729d9d36dd20");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0c65fae-585e-4af5-a304-1a6d5863420c", "AQAAAAEAACcQAAAAENxPQJUvASY6A6d1Z6avvuASCyAyV+eadY9v0i9o2VSR/yKj6SAr3jwY7gRi6kXTww==", "d032e59b-4398-489b-b4f5-d82945480b6d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b93b653-746e-443b-ad18-e5f78cdef852", "AQAAAAEAACcQAAAAEAiy+6+aJhBnYC5C3Pjy84f3st82i9XDRUZ7tEzwk6umQdzJBw8dZ+CMOxgIS92lmQ==", "dd116104-dd26-4d1e-8793-604a0ccaa96a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ecb6df0-19b1-4962-a1ab-08d983e3b762", "AQAAAAEAACcQAAAAEKcoixN/b+4Wp3+h3nHYMT9puV/v57YRgZUBitYApOVJ/xJ1COHCjWR6mj+otbIfvw==", "f8d02980-c245-4f67-8fc2-4703278a9108" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "AccelerationTo100", "BodyType", "ConsumptionPer100Km", "CylindersNumber", "Displacement", "EngineAspirationType", "EngineFuelType", "EngineStructureType", "Horsepower", "ImageURL", "Make", "Mileage", "Model", "PeakHorsepowerAtRPM", "PeakTorqueAtRPM", "PricePerDay", "RenterId", "SafetyRating", "Seats", "TopSpeed", "Torque", "TransmissionType", "YearOfProduction" },
                values: new object[] { new Guid("1201c5ee-8aa7-4400-9009-7bfc91fa4817"), 8.6999999999999993, 0, 8.6999999999999993, 4, 2000, 0, 0, 0, 122, "https://i.pinimg.com/736x/bd/f1/67/bdf167075cbba99b9eeed9393ba24d65.jpg", "Mercedes", 460000, "190E", 5300, 3500, 239.0, null, 9.0999999999999996, 5, 230, 178, 1, 1991 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("1201c5ee-8aa7-4400-9009-7bfc91fa4817"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                column: "ConcurrencyStamp",
                value: "5afc791c-57e2-4e23-8522-141ce2608fd0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88b2b97d-254a-4735-9fa6-ad1de0b88848", "AQAAAAEAACcQAAAAEO656YpS5scD2dh6mCuyanC01QMtouuhy3decb+oqlwJSYiCu2T8sdopDfSQIEsDxg==", "80bc110b-c49a-4a1b-a51a-f1b68b956496" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcbaca9e-5cb6-4082-ad97-13e6a94ebef0", "AQAAAAEAACcQAAAAEACIYvyQ9Ic9vFLO4BCE9PUyXvdGxxUL222f2ROapGdhUjyYuIFjdMBYlDNemRmEwA==", "406b7841-251a-49e2-b20d-068ad57a35d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "386b6ccb-c154-4527-ab01-d5ca9e25fad8", "AQAAAAEAACcQAAAAEKy8vcfx5Ys8hMYOc/qPqfKgtGcgw0Ann/zFHzh7PeqEsdgLGbsx4MP5CT0aaaZo0g==", "7fa06fc7-5308-4272-86c0-c31c7ea72107" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "AccelerationTo100", "BodyType", "ConsumptionPer100Km", "CylindersNumber", "Displacement", "EngineAspirationType", "EngineFuelType", "EngineStructureType", "Horsepower", "ImageURL", "IsActive", "Make", "Mileage", "Model", "PeakHorsepowerAtRPM", "PeakTorqueAtRPM", "PricePerDay", "RenterId", "SafetyRating", "Seats", "TopSpeed", "Torque", "TransmissionType", "YearOfProduction" },
                values: new object[] { new Guid("1201c5ee-8aa7-4400-9009-7bfc91fa4815"), 8.6999999999999993, 0, 8.6999999999999993, 4, 2000, 0, 0, 0, 122, "https://i.pinimg.com/736x/bd/f1/67/bdf167075cbba99b9eeed9393ba24d65.jpg", false, "Mercedes", 460000, "190E", 5300, 3500, 239.0, null, 9.0999999999999996, 5, 230, 178, 1, 1991 });
        }
    }
}
