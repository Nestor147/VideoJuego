using System.ComponentModel.DataAnnotations;

namespace Universidad2.Models
{
    public class Autos
    {
        [Key]
        public int idAuto { get; set; }
        public string color { get; set; }
        public string marca { get; set; }
        public int modelo { get; set; }
    }
}
