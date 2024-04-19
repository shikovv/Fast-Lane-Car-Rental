using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    public partial class test123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                column: "ConcurrencyStamp",
                value: "ee6e858a-cfdc-48e0-9448-083a4bde31bc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2cac2ff-dfc4-4b17-a67e-46533673eda8", "AQAAAAEAACcQAAAAENY/6VmQXsD6m9+n1hQooLL4AX8GKLN9Dh7cNWaX70E5NCZc9lT7/IXKy0jTeSwfOw==", "eeead1f8-954a-42f9-87d9-2d86cc89c992" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "317cc56d-72c9-4c91-8ed0-2941d3a30b1c", "AQAAAAEAACcQAAAAEHeoJekJmAU1k5NC/f0PX/6G9xzj4lo7tUK/yDtjesDfX1fZrGSHB/L0aPVy/QDUtw==", "4f8a9134-3d76-40a5-8f11-a0a6adf3f321" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87efbe39-a884-4da7-8def-7b24d73b02ff", "AQAAAAEAACcQAAAAEGfsLSyZPAzke77+fvoJ4dfZJJuAXJmlLb1SvKgqbF/GN9PlKbxEdDoxk9vrD78zWQ==", "1ee57999-7339-42b7-a760-39623319b6cf" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("1201c5ee-8aa7-4400-9009-7bfc91fa4817"),
                columns: new[] { "AccelerationTo100", "ConsumptionPer100Km", "Displacement", "Horsepower", "ImageURL", "Mileage", "Model", "PeakHorsepowerAtRPM", "PeakTorqueAtRPM", "PricePerDay", "SafetyRating", "Seats", "TopSpeed", "Torque", "TransmissionType" },
                values: new object[] { 4.7000000000000002, 12.699999999999999, 2500, 235, "https://autobild.bg/wp-content/uploads/2021/08/Mercedes-190-E-2.5-16-Evo-II-7.jpg", 41000, "190E EVO 2", 7200, 5000, 2239.9899999999998, 9.3000000000000007, 4, 298, 245, 0 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "AccelerationTo100", "BodyType", "ConsumptionPer100Km", "CylindersNumber", "Displacement", "EngineAspirationType", "EngineFuelType", "EngineStructureType", "Horsepower", "ImageURL", "Make", "Mileage", "Model", "PeakHorsepowerAtRPM", "PeakTorqueAtRPM", "PricePerDay", "RenterId", "SafetyRating", "Seats", "TopSpeed", "Torque", "TransmissionType", "YearOfProduction" },
                values: new object[,]
                {
                    { new Guid("106b584f-2fc0-45ef-985f-ce520e719b3b"), 5.5, 11, 21.600000000000001, 8, 5500, 2, 0, 1, 507, "https://www.historics.co.uk/media/1649547/g-wagon-1.jpg?anchor=center&mode=crop&width=1000", "Mercedes", 210000, "G55 AMG", 6100, 3100, 499.99000000000001, null, 9.6999999999999993, 5, 290, 700, 1, 2009 },
                    { new Guid("2c4f96ad-c259-4494-aec1-d16085794319"), 4.9000000000000004, 0, 13.4, 8, 6000, 0, 0, 1, 381, "https://i0.wp.com/www.klasikotom.com/wp-content/uploads/2019/10/W124-E60-AMG-Mercedes-Benz-Tarihcesi-motor-teknik-ozellikleri-nedir-nasil-nasildir-kps.jpg?fit=639%2C369&ssl=1", "Mercedes", 33000, "E60 AMG", 5500, 3750, 1089.99, null, 9.3000000000000007, 4, 324, 580, 1, 1994 },
                    { new Guid("2ef90e6c-4356-465d-9389-9f6017b808c3"), 10.9, 2, 3.6000000000000001, 4, 1800, 0, 4, 0, 122, "https://www.auto-data.net/images/f15/Toyota-Corolla-XII_1.jpg", "Toyota", 76000, "Corolla", 5200, 3600, 79.989999999999995, null, 6.7000000000000002, 5, 180, 142, 1, 2019 },
                    { new Guid("4fd8c3e0-5b21-44e1-8d0c-b6cae13ad9e2"), 5.9000000000000004, 0, 15.4, 12, 6000, 0, 0, 1, 408, "https://business-car-rent.net/wp-content/uploads/2021/03/mercedes-benz-w140-s600-kaban-brabus-mersedes-dlya-kino-na-semki-bez-voditelya-na-prokat-brabus-mers-kiev-10-1.jpg", "Mercedes", 59000, "S600 SEL", 5200, 3800, 889.99000000000001, null, 9.6999999999999993, 5, 308, 580, 1, 1998 },
                    { new Guid("972f5bfe-0147-48ba-9fa3-a869604e8eb7"), 6.7999999999999998, 3, 7.5999999999999996, 4, 2000, 0, 0, 0, 150, "https://i0.shbdn.com/photos/52/19/80/x5_1163521980bds.jpg", "Renault", 340000, "Megane Coach", 6200, 4200, 199.99000000000001, null, 7.7000000000000002, 4, 243, 190, 0, 1999 }
                });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("6db74b16-8cc7-4709-9fce-9e8a30939efc"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 17, 19, 56, 49, 351, DateTimeKind.Local).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("9bdc6a38-e9f4-4cdf-8b9e-b329e0f0233c"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 17, 19, 56, 49, 351, DateTimeKind.Local).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("df0bd291-45c5-4ac0-a927-27b27ddbd821"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 17, 19, 56, 49, 351, DateTimeKind.Local).AddTicks(5137));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("106b584f-2fc0-45ef-985f-ce520e719b3b"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("2c4f96ad-c259-4494-aec1-d16085794319"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("2ef90e6c-4356-465d-9389-9f6017b808c3"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("4fd8c3e0-5b21-44e1-8d0c-b6cae13ad9e2"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("972f5bfe-0147-48ba-9fa3-a869604e8eb7"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"),
                column: "ConcurrencyStamp",
                value: "b5e790d0-b0bb-4707-b6c6-26d9eef31c5b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5edc49-7490-493f-2f01-08db8a416485"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bdf56c8-a7ba-4c0c-b132-037df0dc7cfc", "AQAAAAEAACcQAAAAEATbSpT6dXK0RU8gXChFGndgiaZNYL1kUBfARiAKxPA7tN7PfyUMwflKddRqeet97g==", "3ed4f738-4998-4665-85d7-d92a61d490a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f06d4765-779a-4766-eb64-08db8a42133c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49e06c3a-32a7-43e6-b777-2eb22198c0da", "AQAAAAEAACcQAAAAEPHv123muFvz4EPs6CvnqA8sA9NdUmEyXQZZO71iLbH0sDcxIRs6NtfhG6WOX/BVlA==", "f3d75306-8806-46d5-b5ab-134fa94ca8c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b68450c4-137b-46e5-a2be-6ea81ca782b8", "AQAAAAEAACcQAAAAEGvKxS5pfi2VuANw1gsLzWVC27sRf0AFNxWIguCDFdDKAivhWCaVdx3+IfMRmmC41g==", "9cafe749-5204-4520-a4c0-b95e59d1b939" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("1201c5ee-8aa7-4400-9009-7bfc91fa4817"),
                columns: new[] { "AccelerationTo100", "ConsumptionPer100Km", "Displacement", "Horsepower", "ImageURL", "Mileage", "Model", "PeakHorsepowerAtRPM", "PeakTorqueAtRPM", "PricePerDay", "SafetyRating", "Seats", "TopSpeed", "Torque", "TransmissionType" },
                values: new object[] { 8.6999999999999993, 8.6999999999999993, 2000, 122, "https://i.pinimg.com/736x/bd/f1/67/bdf167075cbba99b9eeed9393ba24d65.jpg", 460000, "190E", 5300, 3500, 239.0, 9.0999999999999996, 5, 230, 178, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("6db74b16-8cc7-4709-9fce-9e8a30939efc"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 17, 17, 47, 41, 499, DateTimeKind.Local).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("9bdc6a38-e9f4-4cdf-8b9e-b329e0f0233c"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 17, 17, 47, 41, 499, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("df0bd291-45c5-4ac0-a927-27b27ddbd821"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 17, 17, 47, 41, 499, DateTimeKind.Local).AddTicks(188));
        }
    }
}
