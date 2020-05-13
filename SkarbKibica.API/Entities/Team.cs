using System.ComponentModel.DataAnnotations;

namespace SkarbKibica.API.Entities
{
    public class Team
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public int Created { get; set; }

        [Required]
        [MaxLength(50)]
        public string ClubColors { get; set; }

        public Stadium Stadium { get; set; }
    }
}