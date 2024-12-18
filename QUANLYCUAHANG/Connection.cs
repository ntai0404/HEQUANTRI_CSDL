using System;
using System.Data.SqlClient;

namespace QUANLYCUAHANG
{
    public class Connection
    {
        public static SqlConnection GetSqlConnection()
        {
            string connectionString = @"Data Source=DESKTOP-3VR2VQE;Initial Catalog=storedata;Integrated Security=True";
            return new SqlConnection(connectionString);
        }
    }
}

