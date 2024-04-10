using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be3c1d07-4df5-4808-a812-60e5f6938498", "Pesho", "Petrov", "AQAAAAEAACcQAAAAEN631ClGHk0lU0wI7dW3i7B6msTw4FYOY4Pq5gMePsuqPjsUtdMQhqebK0FQzgLQ2g==", "384c6f2b-39ed-4fe1-97bd-24acd490fc3e" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("df0bd291-45c5-4ac0-a927-27b27ddbd821"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 10, 6, 35, 49, 316, DateTimeKind.Utc).AddTicks(1709));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                column: "ConcurrencyStamp",
                value: "2ba343ad-8dae-4674-b554-e8ad474e728d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d94e8384-f0d0-4095-8ecc-1cefb1343758", "AQAAAAEAACcQAAAAEDmS6ijaJ0OaejMNrGZ1qqDHfQy4Wm9rJu0349Y2IxHaJxXssjkFSOKqK7xU6FsNLw==", "f5122e46-9a3e-4a2d-8bfd-4313a031f888" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8f0aaed-ab68-4b96-a931-6096a05460dd", "AQAAAAEAACcQAAAAEPpDTwdZlV+tBiy07cjSiQu1IPgyB/1Pt6F/Qq9Hx56W6WON4luCKenpcFYD0JKDWA==", "aeff0875-5cee-4051-8a9d-534b2b286c84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d320a91-4be0-446a-8d1f-3902ecd509f8", "pesho", "petrov", "AQAAAAEAACcQAAAAEOCh4qvgUQj2ga58pHcoF5/4M7BQ66Ahc0ubN/xq1ObYsBKNEI/IF5HOHPEt4Zyctg==", "975f6b89-3188-4264-a904-c1e44a1a8205" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("df0bd291-45c5-4ac0-a927-27b27ddbd821"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 10, 5, 20, 27, 851, DateTimeKind.Utc).AddTicks(839));
        }
    }
}
