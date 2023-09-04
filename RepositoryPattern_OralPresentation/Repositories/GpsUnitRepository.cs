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
        }

        public GpsUnit GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(GpsUnit gpsUnit)
        {
            _databaseHandler.Insert(gpsUnit);
        }

        public void Update(GpsUnit gpsUnit)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }        
    }
}
