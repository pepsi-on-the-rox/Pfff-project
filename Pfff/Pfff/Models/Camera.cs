using System.ComponentModel.DataAnnotations;

namespace Pfff.Models
{
    public class Camera
    {
        [Key]
        public int CameraID { get; set; }
        public float Latitute { get; set; }
        public float Longitude { get; set; }
        public string Specificatie { get; set; }
        public string Beschrijving { get; set; }
        public Gebruiker Gebruiker { get; set; }


    }
}
