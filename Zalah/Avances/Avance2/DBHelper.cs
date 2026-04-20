using System;
using System.Data.SQLite;

namespace Proyecto_Zalah.Database
{
    public class DBHelper
    {
        private static readonly string connectionString = "Data Source=database/proyecto.db;Version=3;";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        public static void ExecuteNonQuery(string query)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static SQLiteDataReader ExecuteQuery(string query)
        {
            var conn = GetConnection();
            conn.Open();
            var cmd = new SQLiteCommand(query, conn);
            return cmd.ExecuteReader();
        }
    }
}