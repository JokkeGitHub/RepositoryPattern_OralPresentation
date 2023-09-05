using RepositoryPattern_OralPresentation.Models;
using RepositoryPattern_OralPresentation.Repositories;

class Program
{

    static void Main(string[] args)
    {
        GpsUnitRepository repos = new GpsUnitRepository();  


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

        InsertToDatabase(gpsUnit);
        Console.ReadLine();

        DeleteFromDatabase(gpsUnit.ID);
        Console.ReadLine();

        void InsertToDatabase(GpsUnit gpsUnit)
        {
            repos.Insert(gpsUnit);
        }

        void DeleteFromDatabase(int id)
        {
            repos.DeleteById(id);
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

    
        //GpsUnitRepository gpsUnitRepository = new GpsUnitRepository();
    
            //gpsUnitRepository.Insert(gpsUnit);

    
            //gpsUnitRepository.DeleteById(id);
     */
}