using System.ComponentModel.DataAnnotations;

namespace Pfff.Models
{
    public class Gebruiker
    {
        [Key]
        public int GebruikerID { get; set; }
        public string GebruikersNaam { get; set; }
        private string Wachtwoord { get; set; }
        public int Punten { get; set; }
        public int Cameras { get; set; }

    }
}
