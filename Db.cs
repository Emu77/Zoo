
using MySql.Data.MySqlClient;

namespace Zooverwaltung
{
    public static class Db
    {
        // Bitte anpassen an deine MySQL-Installation
        private static string connString =
            "Server=localhost;Database=zoodb;Uid=root;Pwd=;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connString);
        }
    }
}
