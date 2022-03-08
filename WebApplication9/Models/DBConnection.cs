using Microsoft.Data.SqlClient;
namespace WebApplication9.Models

{
    public class DBConnection
    {
        public SqlConnection connection;
        public DBConnection()
        {
            connection = new SqlConnection
                (DbConfig.Connectionstr);
        }

    }
}
