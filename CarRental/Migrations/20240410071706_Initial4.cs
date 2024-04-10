using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    public partial class Initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                column: "ConcurrencyStamp",
                value: "13160ed1-8a3c-4748-a6ec-d42a5cc04215");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1739a20-5f00-4512-9435-e358efa5984f", "AQAAAAEAACcQAAAAEF59OmuPuLoLNSdATGbh+a6t4JCdLLE5Gz+72vs0cID6uu56DSJmnCRJzu1JOxMeng==", "39a3ef11-d435-4ab1-874e-68bae08b8554" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e1d6c8e-fcde-4dac-8da0-f4b0fdee5168", "AQAAAAEAACcQAAAAEERu6HY8wvEAXuh8V8uL0O9HLI7owhimZCZHlK0SBgTe83CU5GT3GkUWYYPxAAWtFA==", "c6c855fc-faac-4b9c-bbbd-90f167462bab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "325ddec7-f258-4fc7-943f-a8809a29d88b", "AQAAAAEAACcQAAAAEObL8krR2+0o6GyIJGukfKpLi9urlgxZ6UnN+tCtTYgnB7uwR8ythkQWzpR5Z9FfEA==", "2e64ea93-46ec-4678-9d49-58372fed97a7" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("6db74b16-8cc7-4709-9fce-9e8a30939efc"),
                columns: new[] { "CreatedOn", "StarsRating", "Title" },
                values: new object[] { new DateTime(2024, 4, 10, 7, 17, 5, 359, DateTimeKind.Utc).AddTicks(6340), 4, "Awesome!" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("9bdc6a38-e9f4-4cdf-8b9e-b329e0f0233c"),
                columns: new[] { "CreatedOn", "StarsRating", "Title" },
                values: new object[] { new DateTime(2024, 4, 10, 7, 17, 5, 359, DateTimeKind.Utc).AddTicks(6329), 4, "The best in the business!" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("df0bd291-45c5-4ac0-a927-27b27ddbd821"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 10, 7, 17, 5, 359, DateTimeKind.Utc).AddTicks(6301));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                column: "ConcurrencyStamp",
                value: "6cb24c0a-e32b-4056-9668-93d5ed76e1ce");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f07b94bd-d402-4717-8b43-294a691c6540", "AQAAAAEAACcQAAAAEKGayu5rz584IDEdhO7EDHhaz/KMAIx3xUqX3E8lXHJrw79KyQuCD3coc3l8eBJGHA==", "39cf4784-8b74-423c-8c22-c3d1d2361639" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "913c6aa3-5766-4f15-b894-2eb1594b768a", "AQAAAAEAACcQAAAAEHHHNk3YpBeiOXa5HeYmIR2gqW5Nv/I+GcJsqIIYVGq9WSox6jd3WS0QQXDPJXWvUg==", "a27bc903-2faf-453e-87b9-d29b6ca38dc0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af227ec7-56a9-4297-a292-7c63c42e13a4", "AQAAAAEAACcQAAAAEPGR2jVmKH5KUFE5zN6nJXcoxa2KgUipxBvqZk4bbPnVzm7+F6cfjKIH+dPv2iF2gA==", "0c7664cc-e55e-41aa-83f1-47baa476ee45" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("6db74b16-8cc7-4709-9fce-9e8a30939efc"),
                columns: new[] { "CreatedOn", "StarsRating", "Title" },
                values: new object[] { new DateTime(2024, 4, 10, 7, 14, 21, 335, DateTimeKind.Utc).AddTicks(5063), 5, "Reccomend it!" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("9bdc6a38-e9f4-4cdf-8b9e-b329e0f0233c"),
                columns: new[] { "CreatedOn", "StarsRating", "Title" },
                values: new object[] { new DateTime(2024, 4, 10, 7, 14, 21, 335, DateTimeKind.Utc).AddTicks(5056), 5, "Reccomend it!" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("df0bd291-45c5-4ac0-a927-27b27ddbd821"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 10, 7, 14, 21, 335, DateTimeKind.Utc).AddTicks(5033));
        }
    }
}
