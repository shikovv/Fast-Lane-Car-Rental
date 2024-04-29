using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRental.Services;
using CarRental.Models.Comment;
using CarRental.Data;
using Microsoft.EntityFrameworkCore;
using CarRental.Data.Domain;
using CarRental.Contracts;

namespace NUnitTests
{
    [TestFixture]
    public class UserServiceTests
    {
        private ApplicationDbContext dbContext;
        private UserService userService;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDb")
                .Options;
            dbContext = new ApplicationDbContext(options);
            userService = new UserService(dbContext);
        }

        [Test]
        public async Task IsUserHavePhoneNumber_ShouldReturnTrue_WhenUserHasPhoneNumber()
        {
            var userId = Guid.NewGuid();
            var userWithPhoneNumber = new ApplicationUser
            {
                Id = userId,
                PhoneNumber = "123456789",
                FirstName="Ivan",
                LastName="Ivanov"
            };
            dbContext.Users.Add(userWithPhoneNumber);
            await dbContext.SaveChangesAsync();
            var result = await userService.IsUserHavePhoneNumber(userId.ToString());
            Assert.IsTrue(result);
        }

        [Test]
        public async Task IsUserHavePhoneNumber_ShouldReturnFalse_WhenUserIdIsNull()
        {
            var result = await userService.IsUserHavePhoneNumber(null);
            Assert.IsFalse(result);
        }

        [Test]
        public async Task IsUserHavePhoneNumber_ShouldReturnFalse_WhenUserDoesNotExist()
        {
            var result = await userService.IsUserHavePhoneNumber(Guid.NewGuid().ToString());
            Assert.IsFalse(result);
        }

        [Test]
        public async Task IsUserHavePhoneNumber_ShouldReturnFalse_WhenUserDoesNotHavePhoneNumber()
        {
            var userId = Guid.NewGuid();
            var userWithoutPhoneNumber = new ApplicationUser
            {
                Id = userId,
                PhoneNumber = null,
                FirstName = "Ivan",
                LastName = "Ivanov"
            };
            dbContext.Users.Add(userWithoutPhoneNumber);
            await dbContext.SaveChangesAsync();
            var result = await userService.IsUserHavePhoneNumber(userId.ToString());
            Assert.IsFalse(result);
        }

    }
}
