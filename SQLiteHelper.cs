

using System.Data.SQLite;

namespace Process
{
    class SQLiteHelper
    {
        private static string connectionString = "Data Source=data.db";
        public static object ExecuteScalar(string sql)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                object result = command.ExecuteScalar();

                return result;
            }
        }
    }
}
