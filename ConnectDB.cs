using System;
using MySql.Data.MySqlClient;

namespace Nabung_Yuk
{
    public class ConnectDB
    {
        private static string connectionString = "server=localhost; port=3306; uid=viraayuokta;" +
            "pwd=check123; database=nabungyuk; charset=utf8; sslMode=none;";
        private static MySqlConnection _connection = new MySqlConnection(connectionString);

        public MySqlConnection connection
        {
            get{
                return _connection;
            }
        }
    }
}