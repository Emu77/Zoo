using MySql.Data.MySqlClient;

namespace Zooverwaltung.Repositories
{
    public abstract class BaseRepository
    {
        // Zentrale DB-Verbindung – nur hier ändern!
        protected const string ConnectionString =
            "server=localhost;uid=root;pwd=;database=zoo;";
    }
}
