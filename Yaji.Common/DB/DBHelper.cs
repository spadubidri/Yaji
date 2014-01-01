using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Yaji.Common
{
    public class DBHelper
    {
        public static SqlConnection OpenConnection()
        {
            SqlConnection con = new SqlConnection();
            
            con.ConnectionString = (string)ConfigurationManager.ConnectionStrings["yajiDB"].ConnectionString;
            con.Open();

            return con;
        }

        public static void CloseConnection(SqlCommand command)
        {
            command.Connection.Close();
        }

        public static SqlDataReader ExecuteReader(SqlCommand command)
        {
            command.Connection = OpenConnection();

            SqlDataReader reader =  command.ExecuteReader();
            return reader;
        }

    }
}
