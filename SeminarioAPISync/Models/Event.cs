using System.Collections.ObjectModel;

namespace SeminarioAPISync.Models
{
    public class Event
    {
        public int IdEvent { get; set; }
        public String NameEvent { get; set; }
        public int IdVenue { get; set; }
        public DateTime DateEvent { get; set; }
        public Collection<Seminar> ListSeminars { get; set; }
    }
}
