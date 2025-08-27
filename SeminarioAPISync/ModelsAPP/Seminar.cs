namespace SeminarioAPISync.Models
{
    public class Seminar
    {
        public int IdSeminar { get; set; }
        public string Name { get; set; }
        public int LenghtInMinutes { get; set; }
        public Event EventName { get; set; }
        public Expositor ExpositorSeminar { get; set; }
    }
}
