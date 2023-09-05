using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern_OralPresentation.DAL.MSSQL.GpsUnits
{
    public class MssqlGpsUnitDelteById : MssqlConnection
    {
        public void DeleteById(int id)
        {
            SqlConnection connection = new SqlConnection(ReturnConnectionString());
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"DELETE FROM GpsUnit WHERE (id) = (@id);";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();

            connection.Close();
        }        
    }
}
