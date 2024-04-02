namespace CarRental.Contracts
{
	public interface IUserService
	{
		Task<bool> IsUserHavePhoneNumber(string userId);
	}
}
