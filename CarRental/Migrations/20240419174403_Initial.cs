using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    BodyType = table.Column<int>(type: "int", nullable: false),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransmissionType = table.Column<int>(type: "int", nullable: false),
                    YearOfProduction = table.Column<int>(type: "int", nullable: false),
                    EngineFuelType = table.Column<int>(type: "int", nullable: false),
                    EngineStructureType = table.Column<int>(type: "int", nullable: false),
                    EngineAspirationType = table.Column<int>(type: "int", nullable: false),
                    CylindersNumber = table.Column<int>(type: "int", nullable: false),
                    Displacement = table.Column<int>(type: "int", nullable: false),
                    Horsepower = table.Column<int>(type: "int", nullable: false),
                    PeakHorsepowerAtRPM = table.Column<int>(type: "int", nullable: false),
                    Torque = table.Column<int>(type: "int", nullable: false),
                    PeakTorqueAtRPM = table.Column<int>(type: "int", nullable: false),
                    AccelerationTo100 = table.Column<double>(type: "float", nullable: false),
                    TopSpeed = table.Column<int>(type: "int", nullable: false),
                    Mileage = table.Column<int>(type: "int", nullable: false),
                    ConsumptionPer100Km = table.Column<double>(type: "float", nullable: false),
                    SafetyRating = table.Column<double>(type: "float", nullable: false),
                    Seats = table.Column<int>(type: "int", nullable: false),
                    PricePerDay = table.Column<double>(type: "float", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RenterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_AspNetUsers_RenterId",
                        column: x => x.RenterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StarsRating = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rentals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Deposit = table.Column<double>(type: "float", nullable: false),
                    CarId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rentals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rentals_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRentals",
                columns: table => new
                {
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RentalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRentals", x => new { x.RentalId, x.CustomerId });
                    table.ForeignKey(
                        name: "FK_UserRentals_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRentals_Rentals_RentalId",
                        column: x => x.RentalId,
                        principalTable: "Rentals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"), "c3a8d0d1-6a86-4528-9707-bef481b3b415", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("8a5edc49-7490-493f-2f01-08db8a416485"), 0, "613c7531-ee75-499d-b423-262167c3cfa2", "admin@gmail.com", false, "Stefan", "Shikov", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEFRAciDdpAFbWFTJHxdSWDSd/gpaFseAOxrt9KShd2Y74f+M4Ykg/iVTYFfKLiAWuQ==", "0988360889", false, "ae243ac7-0b0f-4537-92bf-b70940eb4a21", false, "admin" },
                    { new Guid("f06d4765-779a-4766-eb64-08db8a42133c"), 0, "3aeba5bf-561a-49fa-955d-3851226abb16", "ivan.ivanov@gmail.com", false, "Ivan", "Ivanov", false, null, "IVAN.IVANOV@GMAIL.COM", "IVAN IVANOV", "AQAAAAEAACcQAAAAEAI1JmZZU/GD+JY08TLISB5IYwNP3+3AqxgOpNf7Hq3cklBrsyWWTRIcXhTnCJmn5w==", "0899999999", false, "df7f4d45-a33d-4f8e-a7cc-87ddb18e8736", false, "Ivan Ivanov" },
                    { new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"), 0, "6d09f2ea-c755-4c06-ade3-70793a5db82a", "pesho_petrov@yahoo.com", false, "Pesho", "Petrov", false, null, "PESHO_PETROV@YAHOO.COM", "PESHO_PETROV", "AQAAAAEAACcQAAAAEAOgqf0uAdzNoEemMhcrVnQi9Wy5xtvdC4wpfSsaoFMtguPWu3nXeB2CI2Bp85a3vA==", "0877777777", false, "0b8127b1-83f6-4627-90f8-5b96d42992bb", false, "pesho_petrov" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "AccelerationTo100", "BodyType", "ConsumptionPer100Km", "CylindersNumber", "Displacement", "EngineAspirationType", "EngineFuelType", "EngineStructureType", "Horsepower", "ImageURL", "Make", "Mileage", "Model", "PeakHorsepowerAtRPM", "PeakTorqueAtRPM", "PricePerDay", "RenterId", "SafetyRating", "Seats", "TopSpeed", "Torque", "TransmissionType", "YearOfProduction" },
                values: new object[,]
                {
                    { new Guid("106b584f-2fc0-45ef-985f-ce520e719b3b"), 5.5, 11, 21.600000000000001, 8, 5500, 2, 0, 1, 507, "https://www.historics.co.uk/media/1649547/g-wagon-1.jpg?anchor=center&mode=crop&width=1000", "Mercedes", 210000, "G55 AMG", 6100, 3100, 499.99000000000001, null, 9.6999999999999993, 5, 290, 700, 1, 2009 },
                    { new Guid("1167ef05-3aaf-4ab8-8032-59d4d6bc2076"), 9.8000000000000007, 0, 7.5, 4, 2000, 1, 3, 0, 140, "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/VW_Passat_B7_1.4_TSI_BMT_Trendline_Islandgrau.JPG/1280px-VW_Passat_B7_1.4_TSI_BMT_Trendline_Islandgrau.JPG", "Volkswagen", 120000, "Passat B7", 4200, 2500, 99.0, null, 7.2000000000000002, 5, 211, 320, 1, 2014 },
                    { new Guid("1201c5ee-8aa7-4400-9009-7bfc91fa4817"), 4.7000000000000002, 0, 12.699999999999999, 4, 2500, 0, 0, 0, 235, "https://autobild.bg/wp-content/uploads/2021/08/Mercedes-190-E-2.5-16-Evo-II-7.jpg", "Mercedes", 41000, "190E EVO 2", 7200, 5000, 2239.9899999999998, null, 9.3000000000000007, 4, 298, 245, 0, 1991 },
                    { new Guid("2c4f96ad-c259-4494-aec1-d16085794319"), 4.9000000000000004, 0, 13.4, 8, 6000, 0, 0, 1, 381, "https://i0.wp.com/www.klasikotom.com/wp-content/uploads/2019/10/W124-E60-AMG-Mercedes-Benz-Tarihcesi-motor-teknik-ozellikleri-nedir-nasil-nasildir-kps.jpg?fit=639%2C369&ssl=1", "Mercedes", 33000, "E60 AMG", 5500, 3750, 1089.99, null, 9.3000000000000007, 4, 324, 580, 1, 1994 },
                    { new Guid("2ef90e6c-4356-465d-9389-9f6017b808c3"), 10.9, 2, 3.6000000000000001, 4, 1800, 0, 4, 0, 122, "https://www.auto-data.net/images/f15/Toyota-Corolla-XII_1.jpg", "Toyota", 76000, "Corolla", 5200, 3600, 79.989999999999995, null, 6.7000000000000002, 5, 180, 142, 1, 2019 },
                    { new Guid("4fd8c3e0-5b21-44e1-8d0c-b6cae13ad9e2"), 5.9000000000000004, 0, 15.4, 12, 6000, 0, 0, 1, 408, "https://business-car-rent.net/wp-content/uploads/2021/03/mercedes-benz-w140-s600-kaban-brabus-mersedes-dlya-kino-na-semki-bez-voditelya-na-prokat-brabus-mers-kiev-10-1.jpg", "Mercedes", 59000, "S600 SEL", 5200, 3800, 889.99000000000001, null, 9.6999999999999993, 5, 308, 580, 1, 1998 },
                    { new Guid("972f5bfe-0147-48ba-9fa3-a869604e8eb7"), 6.7999999999999998, 3, 7.5999999999999996, 4, 2000, 0, 0, 0, 150, "https://i0.shbdn.com/photos/52/19/80/x5_1163521980bds.jpg", "Renault", 340000, "Megane Coach", 6200, 4200, 199.99000000000001, null, 7.7000000000000002, 4, 243, 190, 0, 1999 },
                    { new Guid("bdf5c65f-4470-4139-8ec3-8c3baf0e34d6"), 14.1, 2, 6.2999999999999998, 4, 1300, 0, 0, 0, 70, "https://parkers-images.bauersecure.com/wp-images/2148/cut-out/930x620/st05.jpg", "Ford", 260000, "Fiesta MK5", 5000, 2800, 59.0, null, 5.9000000000000004, 5, 180, 106, 0, 2004 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("eba1e76b-c6a4-4d55-96a1-af76b359c115"), new Guid("8a5edc49-7490-493f-2f01-08db8a416485") });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedOn", "CreatorId", "Description", "StarsRating", "Title" },
                values: new object[,]
                {
                    { new Guid("6db74b16-8cc7-4709-9fce-9e8a30939efc"), new DateTime(2024, 4, 19, 20, 44, 3, 125, DateTimeKind.Local).AddTicks(6551), new Guid("8a5edc49-7490-493f-2f01-08db8a416485"), "My experience with Fast Lane Car Rental exceeded all expectations. From booking to drop-off, everything was flawless. The quality of their vehicles and the professionalism of their team truly set them apart. Will definitely be returning for my future rental needs!", 4, "Awesome!" },
                    { new Guid("9bdc6a38-e9f4-4cdf-8b9e-b329e0f0233c"), new DateTime(2024, 4, 19, 20, 44, 3, 125, DateTimeKind.Local).AddTicks(6543), new Guid("f06d4765-779a-4766-eb64-08db8a42133c"), "Fast Lane Car Rental made my trip an absolute breeze! Their extensive selection of vehicles ensured I found the perfect ride for my adventure. The seamless rental process and friendly staff made the experience top-notch. Highly recommend!", 4, "The best in the business!" },
                    { new Guid("df0bd291-45c5-4ac0-a927-27b27ddbd821"), new DateTime(2024, 4, 19, 20, 44, 3, 125, DateTimeKind.Local).AddTicks(6497), new Guid("f2525385-0162-4b42-8fa5-08db8a43496a"), "Exceptional service from Fast Lane Car Rental! The rental process was seamless, and the car exceeded my expectations. Will definitely be using their services again!", 5, "Reccomend it!" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_RenterId",
                table: "Cars",
                column: "RenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CreatorId",
                table: "Comments",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_CarId",
                table: "Rentals",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRentals_CustomerId",
                table: "UserRentals",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "UserRentals");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Rentals");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
