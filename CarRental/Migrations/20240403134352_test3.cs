using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    public partial class test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("1167ef05-3aaf-4ab8-8032-59d4d6bc2075"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                column: "ConcurrencyStamp",
                value: "9d71eb48-51ee-4678-8775-d1abc7050da8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7dabf915-f881-4bd4-b662-007dc6224647", "AQAAAAEAACcQAAAAEHjCqvVTOW87lZ5wNyczUizFJwH2eyhJeaYTZqQoEYSel5Ah4j+pIrAVuJvnuZA/ag==", "b4ff0757-0fb2-485b-bd3a-eaa110f46bdb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f967f0f3-e831-420b-88c4-c88d9895be38", "AQAAAAEAACcQAAAAEHgqE0Ry7N4E20rkXNJj4u12FnU9NuN8LzWRASxUFEqE2yYGEp7EXa4ztSKvhal8XA==", "17b61209-eca5-42b5-b3f1-3f798dfda9d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df1e0c4f-4781-43e8-99cb-21626425587f", "AQAAAAEAACcQAAAAEMD/0zxplNrMB4zS5W/yrAeIUNHmfLOgi/Zoz/bdRrDhv5XJW2i8y0Xpcr7k4xhqAw==", "8fe08bd0-dc20-4490-b19d-3cb4f66b033d" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "AccelerationTo100", "BodyType", "ConsumptionPer100Km", "CylindersNumber", "Displacement", "EngineAspirationType", "EngineFuelType", "EngineStructureType", "Horsepower", "ImageURL", "Make", "Mileage", "Model", "PeakHorsepowerAtRPM", "PeakTorqueAtRPM", "PricePerDay", "RenterId", "SafetyRating", "Seats", "TopSpeed", "Torque", "TransmissionType", "YearOfProduction" },
                values: new object[] { new Guid("1167ef05-3aaf-4ab8-8032-59d4d6bc2076"), 9.8000000000000007, 0, 7.5, 4, 2000, 1, 3, 0, 140, "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/VW_Passat_B7_1.4_TSI_BMT_Trendline_Islandgrau.JPG/1280px-VW_Passat_B7_1.4_TSI_BMT_Trendline_Islandgrau.JPG", "Volkswagen", 120000, "Passat B7", 4200, 2500, 99.0, null, 7.2000000000000002, 5, 211, 320, 1, 2014 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("1167ef05-3aaf-4ab8-8032-59d4d6bc2076"));

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
                columns: new[] { "Id", "AccelerationTo100", "BodyType", "ConsumptionPer100Km", "CylindersNumber", "Displacement", "EngineAspirationType", "EngineFuelType", "EngineStructureType", "Horsepower", "ImageURL", "IsActive", "Make", "Mileage", "Model", "PeakHorsepowerAtRPM", "PeakTorqueAtRPM", "PricePerDay", "RenterId", "SafetyRating", "Seats", "TopSpeed", "Torque", "TransmissionType", "YearOfProduction" },
                values: new object[] { new Guid("1167ef05-3aaf-4ab8-8032-59d4d6bc2075"), 9.8000000000000007, 0, 7.5, 4, 2000, 1, 3, 0, 140, "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/VW_Passat_B7_1.4_TSI_BMT_Trendline_Islandgrau.JPG/1280px-VW_Passat_B7_1.4_TSI_BMT_Trendline_Islandgrau.JPG", false, "Volkswagen", 120000, "Passat B7", 4200, 2500, 99.0, null, 7.2000000000000002, 5, 211, 320, 1, 2014 });
        }
    }
}
