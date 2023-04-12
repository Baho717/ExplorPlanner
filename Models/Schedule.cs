using System.Linq;
namespace ExplorPlanner.Models
{
    public class Schedule
    {
        public Guid Id { get; set; } 
        public string? Title { get; set; }
        public string? Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Location { get; set; }
        public int NumberOfGuest { get; set; }
        public int? ContactPhoneNumber { get; set; }         
    }
}