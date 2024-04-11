using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    public partial class Initial6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                column: "ConcurrencyStamp",
                value: "bac9196c-bff0-4582-b815-ef841e9b6420");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25f84141-d879-4ae4-ba04-a0350ae6a8e3", "AQAAAAEAACcQAAAAEAvVsujl1lmUmTtVQUalaEpI3w0acBgIRmIEK0vPL6B/mk5dNINCyn9lCcoh8XBDRw==", "c16b8da4-dec5-43cc-afd1-011708c9617c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05a945d5-fdd9-4e26-9744-c7251f8bcf05", "AQAAAAEAACcQAAAAEKPwrVd1n2lBU5YExoVYRags7p6sO0eGyTGdtWphXFZzyI5bPJT16v9zh2LOoy6xLA==", "ce9755a2-cff6-4ecc-94fc-0aaecfda1166" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a382899-5df1-4c9a-a8e4-728834f8b4c1", "AQAAAAEAACcQAAAAELhgSAdRWYoQEqhm5bBFM9lsA4bQVcNJJLNsQiSlVTmIAl5SuVQ+GbARcIGaPIyLug==", "6ede26d5-b825-4adb-b4df-5716f9da41e8" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("6db74b16-8cc7-4709-9fce-9e8a30939efc"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 0, 26, 12, 249, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("9bdc6a38-e9f4-4cdf-8b9e-b329e0f0233c"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 0, 26, 12, 249, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("df0bd291-45c5-4ac0-a927-27b27ddbd821"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 0, 26, 12, 249, DateTimeKind.Local).AddTicks(751));
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
