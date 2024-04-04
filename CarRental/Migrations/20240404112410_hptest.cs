using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    public partial class hptest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                column: "ConcurrencyStamp",
                value: "abb6ed5c-542b-4567-ad16-6c00f5a10050");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "082ce662-2971-4de5-be97-b5293e0dbeb0", "AQAAAAEAACcQAAAAEBNjJtJFk8wp9/AGBaNSDllFXc4DWHIzQlpp+lW4zatvOouL4GBTZWuU92P/GV4IRg==", "2771f504-0ca6-43f7-b1cc-68567d8d5853" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db9a01ce-1b8d-407c-b98e-484318e3d5b0", "AQAAAAEAACcQAAAAEA7ElwqMmgmyYg8bOFEjs4Me3/N//iulJjjm+s8u6IqDkGllUW+M7oFHhxAUEjYIkQ==", "e63c39bf-e973-4e1a-a807-56da8bbb13a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5d31350-210f-455f-96f5-21131ae5af9c", "AQAAAAEAACcQAAAAEBd/ew4lEEsA+hGFuPjrBDI1zN2t0u2cqcN9yxRIMA4KJzZ3xGwIuHzTLa3ztyXzYQ==", "fabce856-c0f5-455e-810f-8b966d4eeea4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                column: "ConcurrencyStamp",
                value: "9d71eb48-51ee-4678-8775-d1abc7050da8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7dabf915-f881-4bd4-b662-007dc6224647", "AQAAAAEAACcQAAAAEHjCqvVTOW87lZ5wNyczUizFJwH2eyhJeaYTZqQoEYSel5Ah4j+pIrAVuJvnuZA/ag==", "b4ff0757-0fb2-485b-bd3a-eaa110f46bdb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f967f0f3-e831-420b-88c4-c88d9895be38", "AQAAAAEAACcQAAAAEHgqE0Ry7N4E20rkXNJj4u12FnU9NuN8LzWRASxUFEqE2yYGEp7EXa4ztSKvhal8XA==", "17b61209-eca5-42b5-b3f1-3f798dfda9d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df1e0c4f-4781-43e8-99cb-21626425587f", "AQAAAAEAACcQAAAAEMD/0zxplNrMB4zS5W/yrAeIUNHmfLOgi/Zoz/bdRrDhv5XJW2i8y0Xpcr7k4xhqAw==", "8fe08bd0-dc20-4490-b19d-3cb4f66b033d" });
        }
    }
}
