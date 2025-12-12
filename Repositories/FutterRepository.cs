using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using Zooverwaltung.Models;

namespace Zooverwaltung.Repositories
{
    public class FutterRepository
    {
        public List<Futter> GetAll()
        {
            var list = new List<Futter>();
            using var con = Db.GetConnection();
            con.Open();

            const string sql = "SELECT FutterID, Bezeichnung, Verpackungsgroesse, Kommentar FROM Futter";

            using var cmd = new MySqlCommand(sql, con);
            using var rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                list.Add(new Futter
                {
                    FutterID = rd.GetInt32("FutterID"),
                    Bezeichnung = rd.IsDBNull("Bezeichnung") ? "" : rd.GetString("Bezeichnung"),
                    Verpackungsgroesse = rd.IsDBNull("Verpackungsgroesse") ? "" : rd.GetString("Verpackungsgroesse"),
                    Kommentar = rd.IsDBNull("Kommentar") ? "" : rd.GetString("Kommentar")
                });
            }

            return list;
        }

        public void Insert(Futter f)
        {
            using var con = Db.GetConnection();
            con.Open();

            const string sql =
                @"INSERT INTO Futter (Bezeichnung, Verpackungsgroesse, Kommentar)
                  VALUES (@bez, @verp, @kom)";

            using var cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@bez", f.Bezeichnung);
            cmd.Parameters.AddWithValue("@verp", f.Verpackungsgroesse);
            cmd.Parameters.AddWithValue("@kom", f.Kommentar);

            cmd.ExecuteNonQuery();
        }

        public void Update(Futter f)
        {
            using var con = Db.GetConnection();
            con.Open();

            const string sql =
                @"UPDATE Futter SET
                      Bezeichnung=@bez,
                      Verpackungsgroesse=@verp,
                      Kommentar=@kom
                  WHERE FutterID=@id";

            using var cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@bez", f.Bezeichnung);
            cmd.Parameters.AddWithValue("@verp", f.Verpackungsgroesse);
            cmd.Parameters.AddWithValue("@kom", f.Kommentar);
            cmd.Parameters.AddWithValue("@id", f.FutterID);

            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var con = Db.GetConnection();
            con.Open();

            const string sql = "DELETE FROM Futter WHERE FutterID=@id";

            using var cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }
    }
}
