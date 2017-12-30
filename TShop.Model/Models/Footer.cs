using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TShop.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Id { set; get; }

        [Required]
        [MaxLength(500)]
        public string FooterContent { set; get; }
    }
}