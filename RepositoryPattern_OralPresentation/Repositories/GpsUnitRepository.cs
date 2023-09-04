using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryPattern_OralPresentation.DAL;
using RepositoryPattern_OralPresentation.IRepositories;
using RepositoryPattern_OralPresentation.Models;

namespace RepositoryPattern_OralPresentation.Repositories
{
    public class GpsUnitRepository : IGpsUnitRepository
    {
        private DatabaseHandler _databaseHandler = new DatabaseHandler();

        public IEnumerable<GpsUnit> GetAll()
        {
            throw new NotImplementedException();
            //return _gpsContext.GPSUnits;
        }

        public GpsUnit GetById(int id)
        {
            throw new NotImplementedException();
            //return _gpsContext.GPSUnits.Find(id);
        }

        public void Insert(GpsUnit gpsUnit)
        {
            _databaseHandler.Insert(gpsUnit);
        }

        public void Update(GpsUnit gpsUnit)
        {
            throw new NotImplementedException();
            //_gpsContext.Entry(gpsUnit).State = EntityState.Modified;
        }

        public void DeleteById(int id)
        {

            throw new NotImplementedException();
            //GpsUnit gpsUnit = _gpsContext.GPSUnits.Find(id);
            //_gpsContext.GPSUnits.Remove(gpsUnit);
        }        
    }
}
