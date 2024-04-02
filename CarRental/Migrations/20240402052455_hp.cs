using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    public partial class hp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                column: "ConcurrencyStamp",
                value: "37fa67a5-27f3-4647-9c00-8fefad1d7732");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45eb1ea8-8709-4344-9837-ba6bece4b91d", "AQAAAAEAACcQAAAAEN1wdYrxXsX2CeBrJ6PtbXUMcOT2wrYmufgsCO2NMoxyDMiY9kh4B7RnAwmMA4HtiA==", "98750ca0-98cf-4758-9924-72c4f2c6ceb3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f276db9-a40c-4fc3-9ea0-7cded3e97026", "AQAAAAEAACcQAAAAEGso4xQ0wyOYtIAmlh4HNXxpboRXFQFt7bw2tM6JDBPM2C8g+4XmFrIHkvNhj3VIEA==", "1ca3b3ba-67f6-4573-bfbd-1fe0ddc4a2ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2363ec35-8ead-46c3-8786-e9010d5aeb08", "AQAAAAEAACcQAAAAELb5MljQhmpIhJxuCNUBm0Tm4Ttc6AJdL7W+p8Bxe7myvCRnHae4vBZghkO+fYv+2A==", "9773878f-bf82-4c70-b509-d91d53db4cd5" });
        }
    }
}
