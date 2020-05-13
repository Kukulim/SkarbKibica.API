using System.ComponentModel.DataAnnotations;

namespace SkarbKibica.API.Entities
{
    public class Stadium
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Adress { get; set; }

        [Required]
        [MaxLength(100)]
        public int Seats { get; set; }

        [Required]
        public int TeamId { get; set; }
    }
}