using System.Collections.ObjectModel;
using System.ComponentModel.Design.Serialization;
using SeminarioAPISync;

namespace SeminarioAPISync
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
    public class Event
    {
        public int IdEvent { get; set; }
        public String NameEvent { get; set; }
        public int IdVenue { get; set; }
        public DateTime DateEvent { get; set; }
        public Collection<Seminar> ListSeminars { get; set; }
    }

    public class Expositor
    {
        public int IdExpositor { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }


    public class Seminar
    {
        public int IdSeminar { get; set; }
        public string Name { get; set; }
        public int LenghtInMinutes { get; set; }
        public Event EventName { get; set; }
        public Expositor ExpositorSeminar { get; set; }
    }

}
