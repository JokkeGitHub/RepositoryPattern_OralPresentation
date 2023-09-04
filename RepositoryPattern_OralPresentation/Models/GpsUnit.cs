namespace RepositoryPattern_OralPresentation.Models
{
    public class GpsUnit
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Altitude { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
