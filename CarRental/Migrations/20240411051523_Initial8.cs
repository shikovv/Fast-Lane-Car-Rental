using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    public partial class Initial8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                column: "ConcurrencyStamp",
                value: "43dec4bd-240a-4d64-ba14-84e0bd4b7ea2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "670de735-3407-479c-ba0e-816b2a661f86", "AQAAAAEAACcQAAAAEKcDYwmJGL6W5gtB6yv+8lztUwYrhBsLU/sI3Sg2YFLh90dt6Mox5gtypQyShnE6cQ==", "9ae2ab54-ca23-4378-b8b2-87d57d1c4b5f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80be6dfd-85e7-4896-9fd4-313237795c56", "AQAAAAEAACcQAAAAECmGrqUxDwt054NN9+VQ6LxqaLpnwMMPJY9zmuk4tZx1dnRMsINz966wDTm0JVVzcA==", "074f78d3-add2-484d-8e0a-8bab43be785e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da995354-1442-4ed8-9560-750cb466e853", "AQAAAAEAACcQAAAAECG4iZoHWzjHew6mQXhvm9gsMqH3Q7hHgxNtnWCrlOIhyYsGclsds+f0+7UbOAJIlA==", "1d5177b2-1b46-45e6-8880-8ac06c2ba1ec" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("6db74b16-8cc7-4709-9fce-9e8a30939efc"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 8, 15, 22, 964, DateTimeKind.Local).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("9bdc6a38-e9f4-4cdf-8b9e-b329e0f0233c"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 8, 15, 22, 964, DateTimeKind.Local).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("df0bd291-45c5-4ac0-a927-27b27ddbd821"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 8, 15, 22, 964, DateTimeKind.Local).AddTicks(4022));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                column: "ConcurrencyStamp",
                value: "dfec3c1a-2c2b-4277-904e-ed694b80aa88");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b53d5198-ea9a-4092-9e22-d4097463acf3", "AQAAAAEAACcQAAAAENYu+PrLiJWg4Hb3ONNWWpmFD3CKihEsDQwK2bO6U3X8jZ82nTyy2Rmqrk8hmS62Lg==", "d4c4400a-3921-4acb-a1b6-afdc2e8615e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de15fe46-878f-42d6-9a4a-1d2859d4833b", "AQAAAAEAACcQAAAAEDxwSxZ4Zecewx19o7TQ0+BKuFpd7AJRtOERYMcYEqnTPhH/QdrqFXdZrhor3Hw/2Q==", "8ac5cb10-213c-46c1-836a-af35752b8215" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76434415-65d9-46ea-85ec-cf60c778b241", "AQAAAAEAACcQAAAAEPZ1LBIKwBxM2W9XeE8xdOdFq+gkYVV3YCffu2PDIyFoH0zaWCdesS8vedZ6vbqhGQ==", "6ee9d6f1-f1ba-4d80-b01b-e8386b092c9f" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("6db74b16-8cc7-4709-9fce-9e8a30939efc"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 10, 10, 20, 21, 187, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("9bdc6a38-e9f4-4cdf-8b9e-b329e0f0233c"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 10, 10, 20, 21, 187, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("df0bd291-45c5-4ac0-a927-27b27ddbd821"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 10, 10, 20, 21, 187, DateTimeKind.Local).AddTicks(8472));
        }
    }
}
