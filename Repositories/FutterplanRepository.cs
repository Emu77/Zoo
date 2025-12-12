using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Zooverwaltung.Models;

namespace Zooverwaltung.Repositories
{
    public class FutterplanRepository
    {
        public List<FutterplanEintrag> GetFutterplan(int? tierId, bool sortByTime)
        {
            var list = new List<FutterplanEintrag>();
            using var con = Db.GetConnection();
            con.Open();

            var sql = @"
                SELECT 
                    r.RationID,
                    t.TierID,
                    t.Name AS TierName,
                    f.FutterID,
                    f.Bezeichnung AS FutterName,
                    r.Menge,
                    r.Uhrzeit
                FROM futterration r
                JOIN tiere t ON t.TierID = r.TierID
                JOIN futter f ON f.FutterID = r.FutterID
            ";

            if (tierId.HasValue)
                sql += " WHERE r.TierID=@tid";

            sql += sortByTime
                ? " ORDER BY r.Uhrzeit, t.Name"
                : " ORDER BY t.Name, r.Uhrzeit";

            using var cmd = new MySqlCommand(sql, con);
            if (tierId.HasValue)
                cmd.Parameters.AddWithValue("@tid", tierId.Value);

            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.add(new FutterplanEintrag
                {
                    RationID = rd.GetInt32("RationID"),
                    TierID = rd.GetInt32("TierID"),
                    TierName = rd.GetString("TierName"),
                    FutterID = rd.GetInt32("FutterID"),
                    FutterName = rd.GetString("FutterName"),
                    Menge = rd.IsDBNull("Menge") ? "" : rd.GetString("Menge"),
                    Uhrzeit = rd.GetTimeSpan("Uhrzeit")
                });
            }

            return list;
        }
    }
}
