using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    public partial class home2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                column: "ConcurrencyStamp",
                value: "c08ae49f-1b3a-403d-a275-89be3c69c452");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2601abb5-19c3-4435-8120-8f2d19a4cd58", "AQAAAAEAACcQAAAAEP7+f5BGJQGz/aJGFMJIT/zMr2qXMLcNSUtzNkNmqDxAVgjKuz6Ws22abi5lVud9qA==", "04fb7a1d-d681-4c2d-a63c-0ae68bac4386" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a90d909d-bab0-4637-8960-eddf799268a9", "AQAAAAEAACcQAAAAEGOYyX3Sxn30Cy+hQPJNnjI7/C/5183yN0wiiDTfla+LDD+zTiSqvkjq7z2Cajc8jw==", "7f3660e5-912b-4387-8bee-0d700661c640" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6364fa01-fbbd-48e1-bba1-c161f4f46a09", "AQAAAAEAACcQAAAAENJMJTbApLVZyYunIfuu4VGUMs7IE9GmEUomapKtcFZ/MlJqsnw3rajMBMhMqN1pqg==", "c24ef2eb-04cb-43f8-8fb4-bd3107ca6ec7" });
        }
    }
}
