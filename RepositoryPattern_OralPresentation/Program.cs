using RepositoryPattern_OralPresentation.Models;
using RepositoryPattern_OralPresentation.Repositories;

class Program
{

    static void Main(string[] args)
    {
        GpsUnitRepository gpsUnitRepository = new GpsUnitRepository();

        GpsUnit gpsUnit = new GpsUnit()
        {
            ID = 1,
            Name = "Banan",
            Active = true,
            Latitude = 37.7749,
            Longitude = -122.4194,
            Altitude = 1500,
            Timestamp = DateTime.Now
        };

        PostToDatabase(gpsUnit);

        void PostToDatabase(GpsUnit gpsUnit)
        {
            gpsUnitRepository.Insert(gpsUnit);
        }
    }


    /* 
        "ID": 1,
        "Name":"banan",
        "Latitude ": 37.7749,
        "Longitude": -122.4194,
        "TimeStamp": "2023-08-11T15:30:00Z",
        "Active": true,
        "Altitude": 1500
     */
}