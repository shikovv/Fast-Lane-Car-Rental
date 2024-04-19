using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                column: "ConcurrencyStamp",
                value: "b5e790d0-b0bb-4707-b6c6-26d9eef31c5b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bdf56c8-a7ba-4c0c-b132-037df0dc7cfc", "AQAAAAEAACcQAAAAEATbSpT6dXK0RU8gXChFGndgiaZNYL1kUBfARiAKxPA7tN7PfyUMwflKddRqeet97g==", "3ed4f738-4998-4665-85d7-d92a61d490a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49e06c3a-32a7-43e6-b777-2eb22198c0da", "AQAAAAEAACcQAAAAEPHv123muFvz4EPs6CvnqA8sA9NdUmEyXQZZO71iLbH0sDcxIRs6NtfhG6WOX/BVlA==", "f3d75306-8806-46d5-b5ab-134fa94ca8c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b68450c4-137b-46e5-a2be-6ea81ca782b8", "AQAAAAEAACcQAAAAEGvKxS5pfi2VuANw1gsLzWVC27sRf0AFNxWIguCDFdDKAivhWCaVdx3+IfMRmmC41g==", "9cafe749-5204-4520-a4c0-b95e59d1b939" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("6db74b16-8cc7-4709-9fce-9e8a30939efc"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 17, 17, 47, 41, 499, DateTimeKind.Local).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("9bdc6a38-e9f4-4cdf-8b9e-b329e0f0233c"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 17, 17, 47, 41, 499, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("df0bd291-45c5-4ac0-a927-27b27ddbd821"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 17, 17, 47, 41, 499, DateTimeKind.Local).AddTicks(188));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                column: "ConcurrencyStamp",
                value: "e781e3aa-1866-4da7-8bba-13c0350cbf9e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2beb7c60-91fd-4b38-b76b-313d1b05b146", "AQAAAAEAACcQAAAAEKBAQsR1XuJidkrkpcfN1GA+WKLWh8a8j2cYyiTrxbKHML3th1Td7JnAd17gERiZ4g==", "93267730-e603-4546-ad7d-61c900a778d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "617fab19-cc94-4d2c-bc32-c2971f3324b9", "AQAAAAEAACcQAAAAEIhI3sU/x6UvirXptLnEUL4mzY7nmA5xYZKJBD7oaHRCfX3dSTtREjrdQDFSUL6kRg==", "25761c9b-b522-4cc9-9c70-4e4418cd141d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb29cb6b-f324-4017-b317-bb39f07642f4", "AQAAAAEAACcQAAAAEA4AFus+8sXd4lTi9zoNpQ2tFbzJdEOoCAF3wUyRxEDEe4d6Ef8LLjc5j1shKhRl1A==", "ef6e056a-8146-481f-81de-98841af51e70" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("6db74b16-8cc7-4709-9fce-9e8a30939efc"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 17, 17, 30, 15, 773, DateTimeKind.Local).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("9bdc6a38-e9f4-4cdf-8b9e-b329e0f0233c"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 17, 17, 30, 15, 773, DateTimeKind.Local).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("df0bd291-45c5-4ac0-a927-27b27ddbd821"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 17, 17, 30, 15, 773, DateTimeKind.Local).AddTicks(7898));
        }
    }
}
