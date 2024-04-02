using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Configurations
{
    using CarRental.Data.Domain;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    public class UserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasData(this.GenerateUsers());
        }

        private IEnumerable<ApplicationUser> GenerateUsers()
        {
            var users = new HashSet<ApplicationUser>();
            var hasher = new PasswordHasher<ApplicationUser>();

            ApplicationUser applicationUser;
            applicationUser = new ApplicationUser()
            {
                Id = Guid.Parse("8A5EDC49-7490-493F-2F01-08DB8A416485"),
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                FirstName = "Stefan",
                LastName = "Shikov",
                SecurityStamp = Guid.NewGuid().ToString(),
                PhoneNumber = "0988360889",
            };
            applicationUser.PasswordHash = hasher.HashPassword(applicationUser, "admin");
            users.Add(applicationUser);

            applicationUser = new ApplicationUser()
            {
                Id = Guid.Parse("F06D4765-779A-4766-EB64-08DB8A42133C"),
                UserName = "Ivan Ivanov",
                NormalizedUserName = "IVAN IVANOV",
                Email = "ivan.ivanov@gmail.com",
                NormalizedEmail = "IVAN.IVANOV@GMAIL.COM",
                FirstName = "Ivan",
                LastName = "Ivanov",
                SecurityStamp = Guid.NewGuid().ToString(),
                PhoneNumber = "0899999999",
            };
            applicationUser.PasswordHash = hasher.HashPassword(applicationUser, "123456");
            users.Add(applicationUser);

            applicationUser = new ApplicationUser()
            {
                Id = Guid.Parse("F2525385-0162-4B42-8FA5-08DB8A43496A"),
                UserName = "pesho_petrov",
                NormalizedUserName = "PESHO_PETROV",
                Email = "pesho_petrov@yahoo.com",
                NormalizedEmail = "PESHO_PETROV@YAHOO.COM",
                FirstName = "pesho",
                LastName = "petrov",
                SecurityStamp = Guid.NewGuid().ToString(),
                PhoneNumber = "0877777777",
            };
            applicationUser.PasswordHash = hasher.HashPassword(applicationUser, "123456");
            users.Add(applicationUser);

            return users;
        }
    }
}
