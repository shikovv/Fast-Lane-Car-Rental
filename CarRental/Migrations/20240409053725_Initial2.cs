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
                value: "58c26a36-6e7a-4f0e-ab47-ffd1b915bef3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59f1a34d-8d50-472c-9f1f-18a3a128b153", "AQAAAAEAACcQAAAAEIqFG+Jc/SGtDTq+guqr0c/MB+L8ASst0C0cZuvImK7pHoXP0sV/JP3lXfX/wffhIg==", "c2f8d79f-e48e-4d5f-9825-6897fdca6430" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f40e1ee-bfbd-40f4-9737-913d1735e141", "AQAAAAEAACcQAAAAEKrlOTrsM4bAcGzNJHZMfdmd8tCFcscY2cHdOP4ucEh28kPnkVB0XSLsjEr4shKgTg==", "15a8e602-45c6-49ab-80d5-62f24789d159" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41f7df60-b10e-45f0-ae14-be68b1dd0933", "AQAAAAEAACcQAAAAEL4zqH23EhwIvlzo+c7K0Hmy5Ho3Ta/bt5LeCb4DeD8z9fOrmjjJB1ECpG1BDYkj6Q==", "b7ccd5de-0235-425b-bd2c-d5ae3881bac9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                column: "ConcurrencyStamp",
                value: "e1cbcbd6-fef5-4447-9dd1-1845e9c6dcd3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4090a07-5635-43de-b175-7c04813876ec", "AQAAAAEAACcQAAAAEP8/OdiIoD5XmqG5s9zqTLT1ceHx97Z2a+tHeh5QBruqg3JVRjfzebUfTRpsnFOrNg==", "64567a45-6fa0-41c6-a557-c3fb75a6c588" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d10aa930-0c80-437f-8ab7-549ce63d3af4", "AQAAAAEAACcQAAAAEF9L5p5isKGRvjUgAKZb+vPEAelinmvLW+U2Q1MqMjwzY/pBHHxDWrnRmiJ2aG3QJA==", "66958f76-30f7-4b6a-9da0-e9919446c547" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db6c62c7-462b-4985-9ad1-7d390a37c0d5", "AQAAAAEAACcQAAAAEAoupL7+jfzcxuFaecUbAhTuimdGB19cpQnbTEEy6SBXARcW4kIkSJ6m52vSn/oulw==", "2739c0f0-7b15-4a2c-a3aa-a4f484864e35" });
        }
    }
}
