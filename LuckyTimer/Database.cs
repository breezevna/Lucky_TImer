using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace LuckyTimer
{
    internal class Database
    {
        SqlConnection SqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBaseUsers"].ConnectionString); //asign a database link
        public void openConnection() //opens connection with database
        {
            if (SqlConnection.State == System.Data.ConnectionState.Closed)
            {
                SqlConnection.Open();
            }
        }
        public void CloseConnection() //closes connection with database
        {
            if (SqlConnection.State == System.Data.ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }
        public SqlConnection getConnection() //returns connection with database
        {
            return SqlConnection;
        }
    }
}
