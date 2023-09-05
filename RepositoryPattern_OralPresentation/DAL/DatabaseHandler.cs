using RepositoryPattern_OralPresentation.DAL.FileJSON.GpsUnits;
using RepositoryPattern_OralPresentation.DAL.MSSQL.GpsUnits;
using RepositoryPattern_OralPresentation.Models;

namespace RepositoryPattern_OralPresentation.DAL
{
    public class DatabaseHandler
    {
        public void Insert(GpsUnit gpsUnit)
        {
            FileJsonGpsUnitInsert file = new FileJsonGpsUnitInsert();
            file.Insert(gpsUnit);
            
            MssqlGpsUnitInsert mssql = new MssqlGpsUnitInsert();
            mssql.Insert(gpsUnit);
        }

        public void DeleteById(int id)
        {
            MssqlGpsUnitDelteById mss = new MssqlGpsUnitDelteById();
            mss.DeleteById(id);
        }
    }
}








/*
 * ins
  MssqlGpsUnitInsert mssqlGpsUnitInsert = new MssqlGpsUnitInsert();
  mssqlGpsUnitInsert.Insert(gpsUnit);

  FileJsonGpsUnitInsert fileJsonGpsUnit = new FileJsonGpsUnitInsert();
  fileJsonGpsUnit.Insert(gpsUnit);



  del
  MssqlGpsUnitDelteById mssqGpsUnitDeleteById = new MssqlGpsUnitDelteById();
  mssqGpsUnitDeleteById.DeleteById(id);
 */
