namespace QuickPlanr.Models
{
    public class User
    {
        public int Id { get; set; }            // Primary Key (automatically generated)
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }      // User's email (can be used for login)
        public string PasswordHash { get; set; }  // To store hashed password securely
    }
}
