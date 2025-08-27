namespace SeminarioAPISync.Models
{
    public class Venue
    {
        public int Id { get; set; } 
        public string Address { get; set; }
        public int SeatsAvailables { get; set; }

        public bool isAvailable { get; set; }
    }
}
