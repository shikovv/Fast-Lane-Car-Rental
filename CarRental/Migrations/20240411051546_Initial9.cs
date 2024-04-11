using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    public partial class Initial9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                column: "ConcurrencyStamp",
                value: "903d63b9-14b9-4163-b16e-f269c6c094c5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96772a4a-c362-4108-be7c-434422f8f42d", "AQAAAAEAACcQAAAAEItGuEnUrRW9mBOQWncOGKU3DNpcWkLens+VNXxaJ2Jm5WF+bHTA4rvgRLtEhGviCw==", "5a6bc820-7fc0-4252-80ed-ae2c277bc76d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a8ac9bd-b815-4a0c-b3bd-4b013ba33b30", "AQAAAAEAACcQAAAAEAKiPQ6hjwp5Ou68wS+pcQQv5s+kSBh3UlBkCFGVZCHWrCNi/yLMEIjO2HKwicJ29Q==", "bef82a02-1df5-43cd-8785-2ce58831e7ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02954f4f-59be-4522-bc02-ed32c180738f", "AQAAAAEAACcQAAAAEMzdIqFDVRXNXTJjsiC0l93rFtl4uYWSBBIIzFh8yCaJxrHecxL1n59QbADEekAVjw==", "7ecf7e29-b07a-40f7-b5c2-d2473d12f141" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("6db74b16-8cc7-4709-9fce-9e8a30939efc"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 8, 15, 46, 79, DateTimeKind.Local).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("9bdc6a38-e9f4-4cdf-8b9e-b329e0f0233c"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 8, 15, 46, 79, DateTimeKind.Local).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("df0bd291-45c5-4ac0-a927-27b27ddbd821"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 8, 15, 46, 79, DateTimeKind.Local).AddTicks(4784));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
