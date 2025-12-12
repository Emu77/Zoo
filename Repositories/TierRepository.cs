
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using Zooverwaltung.Models;

namespace Zooverwaltung.Repositories
{
    public class TierRepository : BaseRepository
    {
        public List<Tier> GetAll()
        {
            var list = new List<Tier>();
            using var con = Db.GetConnection();
            con.Open();
            const string sql = "SELECT TierID, Name, Gewicht, Geburtsdatum, TierartID, GehegeID FROM Tiere";
            using var cmd = new MySqlCommand(sql, con);
            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(new Tier
                {
                    TierID = rd.GetInt32("TierID"),
                    Name = rd.GetString("Name"),
                    Gewicht = rd.GetDouble("Gewicht"),
                    Geburtsdatum = rd.GetDateTime("Geburtsdatum"),
                    TierartID = rd.GetInt32("TierartID"),
                    GehegeID = rd.GetInt32("GehegeID")
                });
            }
            return list;
        }

        public void Insert(Tier t)
        {
            using var con = Db.GetConnection();
            con.Open();
            const string sql = @"INSERT INTO Tiere 
                (Name, Gewicht, Geburtsdatum, TierartID, GehegeID) 
                VALUES (@name, @gew, @geb, @art, @geh)";
            using var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@name", t.Name);
            cmd.Parameters.AddWithValue("@gew", t.Gewicht);
            cmd.Parameters.AddWithValue("@geb", t.Geburtsdatum);
            cmd.Parameters.AddWithValue("@art", t.TierartID);
            cmd.Parameters.AddWithValue("@geh", t.GehegeID);
            cmd.ExecuteNonQuery();
        }

        public void Update(Tier t)
        {
            using var con = Db.GetConnection();
            con.Open();
            const string sql = @"UPDATE Tiere SET
                Name=@name,
                Gewicht=@gew,
                Geburtsdatum=@geb,
                TierartID=@art,
                GehegeID=@geh
                WHERE TierID=@id";
            using var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@name", t.Name);
            cmd.Parameters.AddWithValue("@gew", t.Gewicht);
            cmd.Parameters.AddWithValue("@geb", t.Geburtsdatum);
            cmd.Parameters.AddWithValue("@art", t.TierartID);
            cmd.Parameters.AddWithValue("@geh", t.GehegeID);
            cmd.Parameters.AddWithValue("@id", t.TierID);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var con = Db.GetConnection();
            con.Open();
            const string sql = "DELETE FROM Tiere WHERE TierID=@id";
            using var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public DataTable GetOverview()
        {
            var dt = new DataTable();
            using var con = Db.GetConnection();
            con.Open();
            const string sql = @"
                SELECT 
                    Tiere.Name AS Tiername,
                    Tiere.Gewicht,
                    Tierart.TABezeichnung AS Tierart,
                    Gehege.GBezeichnung AS Gehege,
                    Kontinent.Kbezeichnung AS Kontinent
                FROM Tiere
                JOIN Tierart ON Tiere.TierartID = Tierart.TierartID
                JOIN Gehege ON Tiere.GehegeID = Gehege.gID
                JOIN Kontinent ON Gehege.KontinentID = Kontinent.kID;
            ";
            using var da = new MySqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }
    }
}
