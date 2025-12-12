using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Zooverwaltung.Models;

namespace Zooverwaltung.Repositories
{
    public class FutterrationRepository : BaseRepository
    {
        public List<Futterration> GetAll()
        {
            var list = new List<Futterration>();
            using var con = Db.GetConnection();
            con.Open();

            const string sql = @"SELECT 
                                    RationID,
                                    TierID,
                                    FutterID,
                                    Menge,
                                    Uhrzeit
                                 FROM Futterration";

            using var cmd = new MySqlCommand(sql, con);
            using var rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                list.Add(new Futterration
                {
                    RationID = rd.GetInt32("RationID"),
                    TierID = rd.GetInt32("TierID"),
                    FutterID = rd.GetInt32("FutterID"),
                    Menge = rd.GetString("Menge"),
                    Uhrzeit = rd.GetTimeSpan("Uhrzeit")
                });
            }

            return list;
        }

        public void Insert(Futterration r)
        {
            using var con = Db.GetConnection();
            con.Open();

            const string sql = @"INSERT INTO Futterration 
                                 (TierID, FutterID, Menge, Uhrzeit)
                                 VALUES (@tid, @fid, @menge, @uhr)";

            using var cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@tid", r.TierID);
            cmd.Parameters.AddWithValue("@fid", r.FutterID);
            cmd.Parameters.AddWithValue("@menge", r.Menge);
            cmd.Parameters.AddWithValue("@uhr", r.Uhrzeit);

            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var con = Db.GetConnection();
            con.Open();

            const string sql = "DELETE FROM Futterration WHERE RationID=@id";

            using var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }

        public List<Futterration> GetByTier(int tierId)
        {
            var list = new List<Futterration>();
            using var con = Db.GetConnection();
            con.Open();

            const string sql =
                @"SELECT fr.RationID, fr.TierID, fr.FutterID, fr.Menge, fr.Uhrzeit,
                 f.Bezeichnung AS FutterName
          FROM Futterration fr
          JOIN Futter f ON fr.FutterID = f.FutterID
          WHERE fr.TierID = @tid
          ORDER BY fr.Uhrzeit";

            using var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@tid", tierId);

            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(new Futterration
                {
                    RationID = rd.GetInt32("RationID"),
                    TierID = rd.GetInt32("TierID"),
                    FutterID = rd.GetInt32("FutterID"),
                    Menge = rd.GetString("Menge"),
                    Uhrzeit = rd.GetTimeSpan("Uhrzeit"),
                    FutterName = rd.GetString("FutterName")
                });
            }

            return list;
        }

    }
}
