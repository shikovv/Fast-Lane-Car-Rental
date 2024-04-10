using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("df0bd291-45c5-4ac0-a927-27b27ddbd821"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 10, 7, 14, 21, 335, DateTimeKind.Utc).AddTicks(5033));

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedOn", "CreatorId", "Description", "StarsRating", "Title" },
                values: new object[,]
                {
                    { new Guid("6db74b16-8cc7-4709-9fce-9e8a30939efc"), new DateTime(2024, 4, 10, 7, 14, 21, 335, DateTimeKind.Utc).AddTicks(5063), new Guid("8a5edc49-7490-493f-2f01-08db8a416485"), "My experience with Fast Lane Car Rental exceeded all expectations. From booking to drop-off, everything was flawless. The quality of their vehicles and the professionalism of their team truly set them apart. Will definitely be returning for my future rental needs!", 5, "Reccomend it!" },
                    { new Guid("9bdc6a38-e9f4-4cdf-8b9e-b329e0f0233c"), new DateTime(2024, 4, 10, 7, 14, 21, 335, DateTimeKind.Utc).AddTicks(5056), new Guid("f06d4765-779a-4766-eb64-08db8a42133c"), "Fast Lane Car Rental made my trip an absolute breeze! Their extensive selection of vehicles ensured I found the perfect ride for my adventure. The seamless rental process and friendly staff made the experience top-notch. Highly recommend!", 5, "Reccomend it!" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("6db74b16-8cc7-4709-9fce-9e8a30939efc"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("9bdc6a38-e9f4-4cdf-8b9e-b329e0f0233c"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                column: "ConcurrencyStamp",
                value: "f1801148-82f5-4e0e-8659-ed7916a2db27");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe2208c8-5a36-45b5-8b38-a4c33ec6c72f", "AQAAAAEAACcQAAAAEGZ3E/VfVk7S79b1mdVUYbY99EAeQUzr782ob5HJZAWcRevNCxpIaEPK8hBfXgOxAQ==", "5cf92490-44c5-4afd-9e3b-85289d9171d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d297bc7f-e4fa-41ac-83a8-24e446307cf6", "AQAAAAEAACcQAAAAEMKV2tBlXKzFbOB/6rET+UIs7E8IWdFMlLqxw1eoH8JeqruYwG6AyDzMxqCCi6ak2w==", "85223bd4-ef20-45c4-bb69-5dfe37bd579c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be3c1d07-4df5-4808-a812-60e5f6938498", "AQAAAAEAACcQAAAAEN631ClGHk0lU0wI7dW3i7B6msTw4FYOY4Pq5gMePsuqPjsUtdMQhqebK0FQzgLQ2g==", "384c6f2b-39ed-4fe1-97bd-24acd490fc3e" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("df0bd291-45c5-4ac0-a927-27b27ddbd821"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 10, 6, 35, 49, 316, DateTimeKind.Utc).AddTicks(1709));
        }
    }
}
