
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Zooverwaltung.Models;

namespace Zooverwaltung.Repositories
{
    public class KontinentRepository : BaseRepository
    {
        public List<Kontinent> GetAll()
        {
            var list = new List<Kontinent>();
            using var con = Db.GetConnection();
            con.Open();
            const string sql = "SELECT kID, Kbezeichnung FROM Kontinent";
            using var cmd = new MySqlCommand(sql, con);
            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(new Kontinent
                {
                    kID = rd.GetInt32("kID"),
                    Kbezeichnung = rd.GetString("Kbezeichnung")
                });
            }
            return list;
        }

        public void Insert(Kontinent k)
        {
            using var con = Db.GetConnection();
            con.Open();
            const string sql = "INSERT INTO Kontinent (Kbezeichnung) VALUES (@bez)";
            using var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@bez", k.Kbezeichnung);
            cmd.ExecuteNonQuery();
        }

        public void Update(Kontinent k)
        {
            using var con = Db.GetConnection();
            con.Open();
            const string sql = "UPDATE Kontinent SET Kbezeichnung=@bez WHERE kID=@id";
            using var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@bez", k.Kbezeichnung);
            cmd.Parameters.AddWithValue("@id", k.kID);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var con = Db.GetConnection();
            con.Open();
            const string sql = "DELETE FROM Kontinent WHERE kID=@id";
            using var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
