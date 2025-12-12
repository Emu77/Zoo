
namespace Zooverwaltung.Models
{
    public class Futter
    {
        public int FutterID { get; set; }
        public string Bezeichnung { get; set; }
        public string Verpackungsgroesse { get; set; }
        public string Kommentar { get; set; }
        public override string ToString() => Bezeichnung;
    }
}
