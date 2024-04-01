using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    public partial class configurations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                column: "ConcurrencyStamp",
                value: "3906cd2c-2f69-4f14-9e58-d7b6b8412925");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28fc8d99-af2c-434f-b87b-4e2cdd41302d", "AQAAAAEAACcQAAAAEKKOLDzaXingJQ58wM2JHQLLPnKSDsmWUiGkCWCJjYonhRR87DHqjgtmg4U7+2Em8w==", "05fa01f0-4144-4bac-9b2c-d577ab25d43a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9907f6e-6a1a-4b3d-89dd-e911a2d3bc9a", "AQAAAAEAACcQAAAAELAGefaBqBAi/4TWe8zK0AAfvoF9m3G1Chserah8SeeKs8RcRgFv04rYqGDx9baQVw==", "ee2590fa-7aed-4e4f-9b55-248d9484bd7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39709418-9c40-498d-8b76-a315a43b3985", "AQAAAAEAACcQAAAAEJzxEB2rlaelt7dMWEit7hSYxKVgYUyz11meQsBSgLzFkyuX/wJ+VA7lRLkhuV6E8A==", "ab421cc8-251e-44c7-b6cc-05c379eb7dd4" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("a6e93473-1479-442f-a73a-96a5f4f94b2f"),
                column: "ImageURL",
                value: "https://parkers-images.bauersecure.com/wp-images/2148/cut-out/930x620/st05.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                column: "ConcurrencyStamp",
                value: "4a3bfc95-9856-4b5d-87c9-d6f336b07e86");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50608be8-0907-4232-bdd1-a445759fd649", "AQAAAAEAACcQAAAAED9VcPSfM4WkcH/ghEG3X9+BKRXbV86IHKzZP0zJTi2TxXfIzZQd6uYU7AQ4EfeYfw==", "10a7b721-55e6-4f99-92e4-bc84fb4f962e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "611cf95c-fe4a-4857-a190-55ba650c4dff", "AQAAAAEAACcQAAAAELWUHMm4nPeQ8WWlkwfuRcHGX1U5UEcwRuuWt5bj3vKB/No2/k4yqG0KPbVqZDNmAQ==", "60c694eb-5960-42fe-8415-161f71d25684" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72d3e049-bf7e-4805-94ab-6752d5728646", "AQAAAAEAACcQAAAAEAfDBXe5AxaVJbbGF3usUISTS47GGEOUJcIvA8nMdLE8U+FXmF53n2v7tufXyPSD6g==", "8d6ceca8-c1b8-4bc5-8a44-bf31bb407f8e" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("a6e93473-1479-442f-a73a-96a5f4f94b2f"),
                column: "ImageURL",
                value: "~/photos/fiesta.jpg");
        }
    }
}
