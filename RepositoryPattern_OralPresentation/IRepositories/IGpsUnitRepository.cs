using RepositoryPattern_OralPresentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern_OralPresentation.IRepositories
{
    public interface IGpsUnitRepository
    {
        IEnumerable<GpsUnit> GetAll();
        GpsUnit GetById(int id);
        void Insert(GpsUnit gpsUnit);
        void Update(GpsUnit gpsUnit);
        void DeleteById(int id);
    }
}
