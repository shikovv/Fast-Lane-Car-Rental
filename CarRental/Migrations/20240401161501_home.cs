using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    public partial class home : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                column: "ConcurrencyStamp",
                value: "0689cdcd-e953-42f8-8b1c-1f2b2534aa6d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e25a252-bc75-4954-86ae-63cf8b916ecf", "AQAAAAEAACcQAAAAEENg1H2JXIkRVbszgfBlVAX6/RCUq1AckIFM6WwAuITKc+kQzxO47mMtVOPe6eeA6w==", "5dc945db-e407-4b9c-b2c7-3df34f622a3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2384f25-126e-4af7-ab67-72fcb8a4f8e4", "AQAAAAEAACcQAAAAENva+chAoKpy4k2AcKcAvl5n8d4EnzGe8afBVPzKL90YyebMEJx+rN782+qeAQY32w==", "c9e0832a-67f9-404f-aab4-a3fc29dc55a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9c0920d-7f74-4436-9921-256132072320", "AQAAAAEAACcQAAAAEF2muborunoYbd1RmSPk7Ofs0KZIKo2WBoRAKSQz+Gyqqiq771y2oiqlRnOAZkCyUw==", "e3070bea-4e3b-4cc2-a154-65d7f5e1aa57" });
        }
    }
}
