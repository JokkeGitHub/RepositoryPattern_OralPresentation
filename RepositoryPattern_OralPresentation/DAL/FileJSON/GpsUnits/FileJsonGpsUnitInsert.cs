using Newtonsoft.Json;
using RepositoryPattern_OralPresentation.Models;

namespace RepositoryPattern_OralPresentation.DAL.FileJSON.GpsUnits
{
    public class FileJsonGpsUnitInsert : FileJsonPath
    {
        public void Insert(GpsUnit gpsUnit)
        {
            bool append = true;
            TextWriter textWriter = null;

            try
            {
                var gpsUnitContent = JsonConvert.SerializeObject(gpsUnit);
                textWriter = new StreamWriter(ReturnFilePath(), append);
                textWriter.Write(gpsUnitContent);
            }
            finally
            {
                if (textWriter != null)
                {
                    textWriter.Close();
                }
            }
        }
    }
}
