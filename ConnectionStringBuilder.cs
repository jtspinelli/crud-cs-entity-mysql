
using MySql.Data.MySqlClient;

namespace CRUDFuncionarios
{
    internal class ConnectionStringBuilder
    {
        public static string GetConnectionString()
        {
            return new MySqlConnectionStringBuilder
            {
                Server = "db4free.net",
                Database = "testsdb",
                UserID = "jtspinelli",
                Password = "nns8p4QXFM"
            }.GetConnectionString(true);
        }
    }
}
