using RepositoryPattern_OralPresentation.Models;

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
