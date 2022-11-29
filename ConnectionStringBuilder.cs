
using MySql.Data.MySqlClient;

namespace CRUDFuncionarios
{
    internal class ConnectionStringBuilder
    {
        public static string GetConnectionString()
        {
            return new MySqlConnectionStringBuilder
            {
                Server = "sql10.freesqldatabase.com",
                Database = "sql10581330",
                UserID = "sql10581330",
                Password = "nns8p4QXFM",
            }.GetConnectionString(true);
        }
    }
}
