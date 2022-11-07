using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace Persistence.Models
{
    public class Categorie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
       // [DisplayName("Display Order")]
       // [Range(1, 100, ErrorMessage = "La valeur de Display Order doit être comprise en 1 et 100.")]
        public int DisplayOrder { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
