namespace ExplorPlanner.Models
{
    public class Event
    {
        public Guid EventId { get; set; }
        public string? EventName { get; set; }
        public string? EventLocation { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int NumberOfGuest { get; set; }
    }
}