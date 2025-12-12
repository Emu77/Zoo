namespace Zooverwaltung.Models
{
    public class FutterplanEintrag
    {
        public int RationID { get; set; }
        public int TierID { get; set; }
        public int FutterID { get; set; }

        public string TierName { get; set; } = string.Empty;
        public string FutterName { get; set; } = string.Empty;
        public string Menge { get; set; } = string.Empty;

        public System.TimeSpan Uhrzeit { get; set; }

        // 🔥 Für die Übersicht notwendig!
        public System.DateTime Datum { get; set; }
    }
}

