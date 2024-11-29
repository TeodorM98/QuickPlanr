namespace QuickPlanr.Services
{
    public interface IUserService
    {
        Task<bool> RegisterUserAsync(string firstName, string lastName, string email, string password);
    }
}
