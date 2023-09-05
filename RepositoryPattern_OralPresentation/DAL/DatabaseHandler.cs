using RepositoryPattern_OralPresentation.DAL.FileJSON.GpsUnits;
using RepositoryPattern_OralPresentation.DAL.MSSQL.GpsUnits;
using RepositoryPattern_OralPresentation.Models;

namespace RepositoryPattern_OralPresentation.DAL
{
    public class DatabaseHandler
    {
        public void Insert(GpsUnit gpsUnit)
        {
            MssqlGpsUnitInsert mssqlGpsUnitInsert = new MssqlGpsUnitInsert();
            mssqlGpsUnitInsert.Insert(gpsUnit);

            FileJsonGpsUnitInsert fileJsonGpsUnit = new FileJsonGpsUnitInsert();
            fileJsonGpsUnit.Insert(gpsUnit);
        }

        public void DeleteById(int id)
        {
            MssqlGpsUnitDelteById mssqGpsUnitDeleteById = new MssqlGpsUnitDelteById();
            mssqGpsUnitDeleteById.DeleteById(id);
        }
    }
}
