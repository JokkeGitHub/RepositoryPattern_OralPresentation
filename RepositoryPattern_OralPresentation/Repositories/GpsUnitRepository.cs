using RepositoryPattern_OralPresentation.DAL;
using RepositoryPattern_OralPresentation.IRepositories;
using RepositoryPattern_OralPresentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern_OralPresentation.Repositories
{
    internal class GpsUnitRepository : IGpsUnitRepository
    {
        private DatabaseHandler _database = new DatabaseHandler();
        public void DeleteById(int id)
        {
            _database.DeleteById(id);
        }

        public IEnumerable<GpsUnit> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(GpsUnit gpsUnit)
        {
            _database.Insert(gpsUnit);
        }
    }
}
