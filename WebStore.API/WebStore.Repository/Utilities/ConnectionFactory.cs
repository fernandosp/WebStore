using System.Data.SqlClient;

namespace WebStore.Repository.Utilities
{
    public static class ConnectionFactory 
    {
        private static string _sqlConnection =
            "server=23.98.153.101;database=DeveloperDB22;user=developer;password=dev123DEV123";
        public static SqlConnection GetConnection()
        {
            using (var conn = new SqlConnection(_sqlConnection))
            {
                conn.Open();

                return conn;
            }
        }
    }
}
