using RepositoryPattern_OralPresentation.Models;
using RepositoryPattern_OralPresentation.Repositories;

class Program
{

    static void Main(string[] args)
    {
        //GpsUnitRepository gpsUnitRepository = new GpsUnitRepository();

        GpsUnit gpsUnit = new GpsUnit()
        {
            ID = 2,
            Name = "Banan",
            Active = true,
            Latitude = 37.7749,
            Longitude = -122.4194,
            Altitude = 1500,
            Timestamp = DateTime.Now
        };

        SendToDatabase(gpsUnit);
        Console.ReadLine();

        DeleteFromDatabase(gpsUnit.ID);
        Console.ReadLine();

        void SendToDatabase(GpsUnit gpsUnit)
        {
            //gpsUnitRepository.Insert(gpsUnit);
        }

        void DeleteFromDatabase(int id)
        {
            //gpsUnitRepository.DeleteById(id);
        }
    }


    /* 
        "ID": 2,
        "Name":"banan",
        "Latitude ": 37.7749,
        "Longitude": -122.4194,
        "TimeStamp": "2023-08-11T15:30:00Z",
        "Active": true,
        "Altitude": 1500
     */
}