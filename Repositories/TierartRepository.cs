
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Zooverwaltung.Models;

namespace Zooverwaltung.Repositories
{
    public class TierartRepository
    {
        public List<Tierart> GetAll()
        {
            var list = new List<Tierart>();
            using var con = Db.GetConnection();
            con.Open();
            const string sql = "SELECT TierartID, TABezeichnung FROM Tierart";
            using var cmd = new MySqlCommand(sql, con);
            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(new Tierart
                {
                    TierartID = rd.GetInt32("TierartID"),
                    TABezeichnung = rd.GetString("TABezeichnung")
                });
            }
            return list;
        }

        public void Insert(Tierart t)
        {
            using var con = Db.GetConnection();
            con.Open();
            const string sql = "INSERT INTO Tierart (TABezeichnung) VALUES (@bez)";
            using var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@bez", t.TABezeichnung);
            cmd.ExecuteNonQuery();
        }

        public void Update(Tierart t)
        {
            using var con = Db.GetConnection();
            con.Open();
            const string sql = "UPDATE Tierart SET TABezeichnung=@bez WHERE TierartID=@id";
            using var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@bez", t.TABezeichnung);
            cmd.Parameters.AddWithValue("@id", t.TierartID);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var con = Db.GetConnection();
            con.Open();
            const string sql = "DELETE FROM Tierart WHERE TierartID=@id";
            using var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
