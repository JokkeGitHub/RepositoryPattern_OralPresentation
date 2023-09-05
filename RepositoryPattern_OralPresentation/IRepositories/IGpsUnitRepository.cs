using RepositoryPattern_OralPresentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern_OralPresentation.IRepositories
{
    internal interface IGpsUnitRepository
    {
        IEnumerable<GpsUnit> GetAll();
        void Insert(GpsUnit gpsUnit);
        void DeleteById(int id);
    }
}
