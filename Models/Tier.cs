
using System;

namespace Zooverwaltung.Models
{
    public class Tier
    {
        public int TierID { get; set; }
        public string Name { get; set; }
        public double Gewicht { get; set; }
        public DateTime Geburtsdatum { get; set; }
        public int TierartID { get; set; }
        public int GehegeID { get; set; }
    }
}
