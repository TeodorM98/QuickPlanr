namespace QuickPlanr.Models
{
    public class Meeting
    {
        public int Id { get; set; }                  // Primary Key
        public DateTime MeetingTime { get; set; }    // Time of the meeting
        public int UserId { get; set; }              // Foreign Key to User (owner/creator)
        public User User { get; set; }               // Navigation property (link to the User)
        public string Description { get; set; }      // Optional description of the meeting
        public string Location { get; set; }         // Optional location of the meeting

        // Other properties can be added, like meeting duration, status (scheduled/canceled), etc.
    }
}
