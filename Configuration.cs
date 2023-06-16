using System.Data.SqlClient;

namespace Data_Base_Project
{
    public static class Configuration
    {
        public static SqlConnection connection = null;
        public static SqlDataReader reader = null;
        public static SqlCommand command = null;
        public static readonly string connectionString = "Data Source=AHMED-TAHA\\MSSQLSERVER02; Initial Catalog=Library; Integrated Security= True";
        public static void initilizeConnection()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }
        public static void terminateConnection()
        {
            if (connection != null)
                connection.Close();
            if (reader != null)
                reader.Close();
            connection = null;
            reader = null;
            command = null;
        }
    }
}