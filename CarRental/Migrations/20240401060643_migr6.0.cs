using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    public partial class migr60 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"), "18f622e8-04aa-47c9-a03d-b9c13c1d701e", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("8a5edc49-7490-493f-2f01-08db8a416485"), 0, "8e5a886c-508e-4423-8172-b20c278c9a88", "admin@gmail.com", false, "Stefan", "Shikov", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEAZXgP01JCfMuWrCL2JAmE6EnKAp3hjYeHWIduUBq+GkUjODOIQQdjheHbywRdDicg==", "0988360889", false, "6d181da8-8cd2-45ba-beb9-54ba438a0d6a", false, "admin" },
                    { new Guid("f06d4765-779a-4766-eb64-08db8a42133c"), 0, "d100c5e0-3c06-4f17-837f-27193432368e", "ivan.ivanov@gmail.com", false, "Ivan", "Ivanov", false, null, "IVAN.IVANOV@GMAIL.COM", "IVAN IVANOV", "AQAAAAEAACcQAAAAEEVXTLFzyD2no5KvXJBiQJNI7WAUqAzDVp5q20klwtAchqTQLJaw08t6Wx8h4gxwuA==", "0899999999", false, "42793372-5ebf-449e-bf3e-691128bd8322", false, "Ivan Ivanov" },
                    { new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"), 0, "3885e10d-2571-4fe4-9551-71db9b0f35ca", "pesho_petrov@yahoo.com", false, "pesho", "petrov", false, null, "PESHO_PETROV@YAHOO.COM", "PESHO_PETROV", "AQAAAAEAACcQAAAAEAIXR+C65IwSO0DZARCvnP+J0ianWu0kCJx1afFOVhL4/3EFkDkDtcox5pju0mUWOA==", "0877777777", false, "00969a08-0f2f-4cff-893d-bcb65891fb2e", false, "pesho_petrov" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "AccelerationTo100", "BodyType", "ConsumptionPer100Km", "CylindersNumber", "Displacement", "EngineAspirationType", "EngineFuelType", "EngineStructureType", "Horsepower", "ImageURL", "Make", "Mileage", "Model", "PeakHorsepowerAtRPM", "PeakTorqueAtRPM", "PricePerDay", "RenterId", "SafetyRating", "Seats", "TopSpeed", "Torque", "TransmissionType", "YearOfProduction" },
                values: new object[] { new Guid("a6e93473-1479-442f-a73a-96a5f4f94b2f"), 14.1, 2, 6.2999999999999998, 4, 1300, 0, 0, 0, 70, "https://parkers-images.bauersecure.com/wp-images/2148/cut-out/930x620/st05.jpg", "Ford", 260000, "Fiesta MK5", 5000, 2800, 59.0, null, 5.9000000000000004, 5, 180, 106, 0, 2004 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"), new Guid("8a5edc49-7490-493f-2f01-08db8a416485") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"), new Guid("8a5edc49-7490-493f-2f01-08db8a416485") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("a6e93473-1479-442f-a73a-96a5f4f94b2f"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"));

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Cars",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);
        }
    }
}
