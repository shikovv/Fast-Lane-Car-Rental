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
                value: "5afc791c-57e2-4e23-8522-141ce2608fd0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88b2b97d-254a-4735-9fa6-ad1de0b88848", "AQAAAAEAACcQAAAAEO656YpS5scD2dh6mCuyanC01QMtouuhy3decb+oqlwJSYiCu2T8sdopDfSQIEsDxg==", "80bc110b-c49a-4a1b-a51a-f1b68b956496" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcbaca9e-5cb6-4082-ad97-13e6a94ebef0", "AQAAAAEAACcQAAAAEACIYvyQ9Ic9vFLO4BCE9PUyXvdGxxUL222f2ROapGdhUjyYuIFjdMBYlDNemRmEwA==", "406b7841-251a-49e2-b20d-068ad57a35d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "386b6ccb-c154-4527-ab01-d5ca9e25fad8", "AQAAAAEAACcQAAAAEKy8vcfx5Ys8hMYOc/qPqfKgtGcgw0Ann/zFHzh7PeqEsdgLGbsx4MP5CT0aaaZo0g==", "7fa06fc7-5308-4272-86c0-c31c7ea72107" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                column: "ConcurrencyStamp",
                value: "eb926679-0cdb-43e4-82fe-c7d64be99c38");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae7761b7-7181-45e7-9fca-35755be4485f", "AQAAAAEAACcQAAAAEJZMtMweOBa5+AwRRGHz//H3C2CzOZ5YohQYI5EiPdXS7veLLusKegQFziSwvfLobw==", "bf2c5372-23af-4a21-b348-5c4df143f34f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45e81d68-448e-4148-882e-fddab9497a5d", "AQAAAAEAACcQAAAAEEq0RPAOqnXnIHBI5r7iQiPNE+8RANREZ/xQuZSvj0hO2j+Ml/JuZI3k20ioCq2CkQ==", "732aa3bb-2b59-4c04-8109-0f8c605d6c72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d0f24be-8c29-4c27-a929-b2302016740a", "AQAAAAEAACcQAAAAEAmueKpMa4pQdXlkMqoTSIw89fa60L7wBjYwmGR83O0z0U2BO7+6ldzRdwLgpLyAfA==", "45ff226c-4cbc-4647-bb39-8cbd2733961f" });
        }
    }
}
