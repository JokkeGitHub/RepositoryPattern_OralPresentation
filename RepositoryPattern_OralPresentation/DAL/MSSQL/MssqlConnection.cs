namespace RepositoryPattern_OralPresentation.DAL.MSSQL
{
    public class MssqlConnection
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GPSDB;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public string ReturnConnectionString()
        {
            return connectionString;
        }
    }
}
