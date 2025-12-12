
using System;

namespace Zooverwaltung.Models
{
    public class Futterration
    {
        public int RationID { get; set; }
        public int TierID { get; set; }
        public int FutterID { get; set; }
        public string Menge { get; set; }
        public TimeSpan Uhrzeit { get; set; }
        public string FutterName { get; set; }

        public string Anzeige => $"[{Uhrzeit:hh\\:mm}] {FutterName} - {Menge}";
    }
}
