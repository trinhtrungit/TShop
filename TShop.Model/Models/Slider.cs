using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TShop.Model.Models
{
    [Table("Sliders")]
    public class Slider
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }

        [Required]
        [MaxLength(200)]
        public string Name { set; get; }

        [Required]
        [MaxLength(300)]
        public string Image { set; get; }

        [Required]
        [MaxLength(300)]
        public string Url { set; get; }

        public string Description { set; get; }
        public int? DisplayOrder { set; get; }
        public bool? Status { set; get; }
    }
}