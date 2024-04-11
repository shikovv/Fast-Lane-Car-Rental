using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    public partial class Initial7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                column: "ConcurrencyStamp",
                value: "2ebd27a5-8392-473c-a880-913755fdfbe2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26f67d85-ec64-47c7-aa74-c0c4c5084bcf", "AQAAAAEAACcQAAAAECaOfjqcwUUhPaKjEKlDRyOx6V+/z4skNln2nZkRyeklTWgxbvs0TcaHR4O9tX0mGg==", "34d0c1c6-62b4-4411-aff0-78aee1bc6806" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "346a7ab5-e71c-4e2e-816e-3cdc31d630e4", "AQAAAAEAACcQAAAAEBPICpB/xZz5MJakf0sTJdnxo9DYngbUM1prq+e+KaV50h7Zv/9XG91Y/YD7YMCgZg==", "322b7840-8a21-445a-8e9b-ce3afb5602fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9de3cf5e-d263-454a-a3a9-b03cdd850358", "AQAAAAEAACcQAAAAEHmcTo0KTmMESEXQgweyb2RYoNAdidsXpBYtvtkzF1eGw/0jPtkf0mowQ9iBBnPS8Q==", "0c2bbb3e-eeea-4c90-b0b7-edd4adaabcb1" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("6db74b16-8cc7-4709-9fce-9e8a30939efc"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 0, 26, 45, 476, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("9bdc6a38-e9f4-4cdf-8b9e-b329e0f0233c"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 0, 26, 45, 476, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("df0bd291-45c5-4ac0-a927-27b27ddbd821"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 0, 26, 45, 476, DateTimeKind.Local).AddTicks(7515));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
