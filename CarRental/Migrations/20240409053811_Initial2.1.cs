using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    public partial class Initial21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                column: "ConcurrencyStamp",
                value: "e1ba810a-0159-4070-b5f2-0ead9987feef");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "375ed5fd-c6c1-4157-8fe4-d98409e1541a", "AQAAAAEAACcQAAAAENMKC0EpvltTT5kojYf4Uy+8nNfmTOg7Q06NaMLL415qsUjX4yAciJmyKMJ/f2hbLQ==", "3515c18a-0974-4c38-9ca8-bb1df668bf67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "145202f3-84c3-421e-80d3-ceb10ca4d158", "AQAAAAEAACcQAAAAEOmML4UwmHPk6le6FkL6QL0XC0CCxOBZylOfhbJ5AFXMst5i6+jLnUwcRHd9hiaW3Q==", "e4ba4b02-cece-4665-ae7c-a493eed4bc84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fffe7556-063d-45c0-baae-5dda8b3b81cc", "AQAAAAEAACcQAAAAEMNO/1h0890JWv3bOhpMVYEezceC40r4ft5fCbq35h0Uye8UwW81bTSOShKvXZ3ICA==", "6ae3291d-5c2d-4a71-86a6-ac841aefb2e2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
