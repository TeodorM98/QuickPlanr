namespace QuickPlanr.Models
{
    public class Schedule
    {
        public int Id { get; set; }                  // Primary Key
        public int UserId { get; set; }              // Foreign Key to User (the user whose schedule this is)
        public User User { get; set; }               // Navigation property (link to User)
        public DateTime AvailableFrom { get; set; }   // Start time of availability
        public DateTime AvailableTo { get; set; }     // End time of availability

        // Optionally, you can add availability for different days, recurring schedules, etc.
    }
}
