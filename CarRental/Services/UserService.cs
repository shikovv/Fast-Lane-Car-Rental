using CarRental.Contracts;
using CarRental.Data;
using CarRental.Data.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Services
{
	public class UserService : IUserService
	{
		private readonly ApplicationDbContext context;

		public UserService(ApplicationDbContext context)
		{
			this.context = context;
		}

		public async Task<bool> IsUserHavePhoneNumber(string userId)
		{
			if (string.IsNullOrWhiteSpace(userId))
			{
				return false;
			}

			ApplicationUser? user = await this.context
				.Users
				.FirstOrDefaultAsync(u => u.Id.ToString().ToLower() == userId.ToLower());

			if (user == null)
			{
				return false;
			}

			return user.PhoneNumber != null;
		}
	}
}
