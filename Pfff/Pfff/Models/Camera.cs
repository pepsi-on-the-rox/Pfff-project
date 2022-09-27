using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Pfff.Models
{
    public class Camera
    {
        [Key]
        public int CameraID { get; set; }
        [Required]
        public float Latitute { get; set; }
        [Required]
        public float Longitude { get; set; }
        public string Specificatie { get; set; }
        public string Beschrijving { get; set; }

        
        public Gebruiker Gebruiker { get; set; }


        



    }

    
    
}
