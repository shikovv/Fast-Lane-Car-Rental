using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    public partial class home3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                column: "ConcurrencyStamp",
                value: "f496f93d-9a03-4762-bcdd-5696bc0d7607");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f3176fd-7fff-4238-aee1-95b7ec0f1dd7", "AQAAAAEAACcQAAAAEPzFULCNf8U/7a26JnU+oGGn9M1DMNEXzmusnBOiTHOSxq7wyQwxEM45afsncw+Ipw==", "0b80fd58-0058-4568-8fb9-9ba541e73ec1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f72089d-4efd-4cbc-85ee-d09b15f36293", "AQAAAAEAACcQAAAAENAK+FtNNqyXxs3lI/FH7dHYLeGEqyGliFcOwom+lkeFsV3UiDUkmvA1Agl7v42aaA==", "02310de9-5638-450f-8674-3901359c0933" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f20f8ac0-1813-47ca-bd51-4c1fc7b23ff6", "AQAAAAEAACcQAAAAEHnNt712RwfzUlC09UOF25OX0dw0Z4EokvtEVyXk65RMJH8mD97ktVBIvmaEZb1sWw==", "42f9848d-5d71-47ab-8fd3-7e24d663b30a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                column: "ConcurrencyStamp",
                value: "ca0735c1-e713-4822-835b-1e16faeaff6a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e309b482-2dc8-44dc-9231-60218133f6cb", "AQAAAAEAACcQAAAAEOhcYqx/DNRmIyo5gREFWy2wubBpXR97d6maaq2QKc/IjAko4s8i+UUZ4MoP1C8MFg==", "e2fbd404-d8e8-42dc-a320-ac3d3bbf37fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0bee0c4b-f2f5-4b72-ae76-2b7e9670d08a", "AQAAAAEAACcQAAAAEJSNsyAonuRj4JgKmHVo+QehUUvzjH4umZW/CgvfHKXFNqcYMVEHJV7Akyq2K6hlcQ==", "f9902572-111c-4071-b71e-0c3d14db71b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bf79df0-03db-4de9-8224-7cf650b516b1", "AQAAAAEAACcQAAAAEPKuhgvuwpPx4ogYaIKOKk4WYI1en3iyp2cJAohruhozDFatL+s2h2U/wTN1SuVr1A==", "7f80f599-6299-4a29-9926-9ebf85dc9efb" });
        }
    }
}
