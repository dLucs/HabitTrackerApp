using Microsoft.Data.Sqlite;

namespace HabitTrackerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=HabitTrackerApp.db";
            using(var connection =new SqliteConnection(connectionString))
            {
                connection.Open();
                var tableCmd=connection.CreateCommand();
                tableCmd.CommandText = "";
                tableCmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}