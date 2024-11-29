using QuickPlanr.Data;
using QuickPlanr.Models;

namespace QuickPlanr.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _dbContext;

        public UserService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> RegisterUserAsync(string firstName, string lastName, string email, string password)
        {
            // Example of registering a user:
            try
            {
                // Hash the password (you'd use a library like BCrypt or Identity)
                string hashedPassword = password;//BCrypt.Net.BCrypt.HashPassword(password);

                // Create a user object (ensure you have a User model)
                var user = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    PasswordHash = hashedPassword,
                    //CreatedAt = DateTime.UtcNow
                };

                // Save the user to the database
                _dbContext.Users.Add(user);
                await _dbContext.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
