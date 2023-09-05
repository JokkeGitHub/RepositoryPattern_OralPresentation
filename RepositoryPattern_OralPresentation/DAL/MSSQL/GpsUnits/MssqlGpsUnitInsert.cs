using RepositoryPattern_OralPresentation.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RepositoryPattern_OralPresentation.DAL.MSSQL.GpsUnits
{
    public class MssqlGpsUnitInsert : MssqlConnection
    {
        public void Insert(GpsUnit gpsUnit)
        {
            SqlConnection connection = new SqlConnection(ReturnConnectionString());
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            command.CommandText = @"INSERT INTO GpsUnit(id, name, active, latitude, longitude, altitude, timestamp) VALUES (@id, @name, @active, @latitude, @longitude, @altitude, @timestamp)";
            command.Parameters.AddWithValue("@id", gpsUnit.ID);
            command.Parameters.AddWithValue("@name", gpsUnit.Name);
            command.Parameters.AddWithValue("@active", gpsUnit.Active);
            command.Parameters.AddWithValue("@latitude", gpsUnit.Latitude);
            command.Parameters.AddWithValue("@longitude", gpsUnit.Longitude);
            command.Parameters.AddWithValue("@altitude", gpsUnit.Altitude);
            command.Parameters.AddWithValue("@timestamp", gpsUnit.Timestamp);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            connection.Close();
        }
    }
}
