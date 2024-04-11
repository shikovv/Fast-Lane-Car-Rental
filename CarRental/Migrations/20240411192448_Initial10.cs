using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    public partial class Initial10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                column: "ConcurrencyStamp",
                value: "3f6b1ba5-efe1-4b13-bdc9-02f70b20b61c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18c4b810-f4cf-4703-9b00-86ec2085f1c9", "AQAAAAEAACcQAAAAENMsYK3cU4YkyPGQavSwM3u6JIdY0tOFO0HQbnHwNsAo77KIvPDKp63aSh8r479g/g==", "215ae6d9-7462-4ea6-83fe-f53314b48f7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc14491b-310a-4b47-8bd6-b9885ae15d15", "AQAAAAEAACcQAAAAEBxltIVXIBp+4qeQgnNoylObGXFIwcNR+DFKmyruwGGjTyRXvHnomXmsw4uULF0WWA==", "66d93f64-5c26-4585-ae62-3c6461d200f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1796e3e8-cf33-4cf6-8571-62bbcbcb484f", "AQAAAAEAACcQAAAAEMVGyCSTmA3qMqiY4DGVRYIdJ7u+oTXC9lIOFMDMW/wDV7ukr/U1BaoTDL7V1sTMSA==", "4747394c-3e11-4395-b3cc-ddfa99b7b58b" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("6db74b16-8cc7-4709-9fce-9e8a30939efc"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 22, 24, 47, 622, DateTimeKind.Local).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("9bdc6a38-e9f4-4cdf-8b9e-b329e0f0233c"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 22, 24, 47, 622, DateTimeKind.Local).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("df0bd291-45c5-4ac0-a927-27b27ddbd821"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 22, 24, 47, 622, DateTimeKind.Local).AddTicks(9621));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
